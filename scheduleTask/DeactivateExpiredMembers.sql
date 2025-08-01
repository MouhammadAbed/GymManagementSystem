;WITH LatestSubscriptions AS
(
    SELECT 
        S.subscription_id,
        S.Application_id,
        S.subscriptions_end_date,
        ROW_NUMBER() OVER (PARTITION BY S.Application_id ORDER BY S.subscription_id DESC) AS rn
    FROM Subscriptions S
    WHERE S.isDelete = 0 AND S.isRefund = 0
)

-- Update Applications that have expired subscriptions and are still marked active
UPDATE A
SET A.application_status = 0
FROM Applications A
INNER JOIN LatestSubscriptions LS ON LS.Application_id = A.application_id AND LS.rn = 1
WHERE CAST(LS.subscriptions_end_date AS DATE) <= CAST(GETDATE() AS DATE)
  AND A.application_status = 1;

-- Update Members to inactive if none of their applications are active
UPDATE Members
SET membership_status = 0
WHERE memberId IN (
    SELECT A.member_id
    FROM Applications A
    WHERE A.application_status = 0
    GROUP BY A.member_id
    HAVING COUNT(CASE WHEN A.application_status = 1 THEN 1 END) = 0
);
