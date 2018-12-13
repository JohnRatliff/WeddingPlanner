USE weddingplanner;

DROP VIEW IF EXISTS DVW_Wedding;

CREATE VIEW DVW_Wedding AS
SELECT
    a.WeddingId
  , a.CreatorName
  , a.WedderOneTwoFirstName
  , a.WeddingDate
  , a.Address
  , a.CreatorUserId
  , a.WedderOneUserId
  , a.WedderTwoUserId
  , a.CreatedAt
  , a.UpdatedAt
  , a.GuestCount
  , COALESCE(CONCAT( a.GuestIds, ','),"") AS GuestIds
  FROM (
        SELECT
            weddings.WeddingId
          , CONCAT( creatorUsers.FirstName, ' ', creatorUsers.LastName) AS CreatorName
          , CONCAT( wedderOneUsers.FirstName, ' & ', wedderTwoUsers.FirstName) AS WedderOneTwoFirstName
          , weddings.WeddingDate
          , weddings.Address
          , weddings.CreatorUserId
          , weddings.WedderOneUserId
          , weddings.WedderTwoUserId
          , weddings.CreatedAt
          , weddings.UpdatedAt
          , COALESCE( COUNT(users.UserId), 0) AS GuestCount
          , GROUP_CONCAT( CAST( guests.UserId AS CHAR)) AS GuestIds
          FROM weddings
          INNER JOIN users creatorUsers on creatorUsers.UserId = weddings.CreatorUserId
          INNER JOIN users wedderOneUsers on wedderOneUsers.userId = weddings.WedderOneUserId
          INNER JOIN users wedderTwoUsers on wedderTwoUsers.userId = weddings.WedderTwoUserId
          LEFT OUTER JOIN guests ON guests.WeddingId = weddings.WeddingId
          LEFT OUTER JOIN users on users.UserId = guests.UserId
          GROUP BY
            weddings.WeddingId
          , weddings.WeddingDate
          , weddings.Address
          , weddings.CreatorUserId
          , weddings.WedderOneUserId
          , weddings.WedderTwoUserId
        ) a;

