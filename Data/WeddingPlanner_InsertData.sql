USE weddingplanner;

SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE guests;
TRUNCATE TABLE users;
TRUNCATE TABLE weddings;
SET FOREIGN_KEY_CHECKS = 1;

INSERT INTO users (Email, FirstName, LastName, Password) VALUES
  ('a@gmail.com', 'Andy', 'Apple', 'AQAAAAEAACcQAAAAEHH5LxSHlafnNVM+HgObP3UnAgCtfeJJUjJslrJ1pIwhRO0G3nDCkDex3DpNlyly6Q==')
, ('b@gmail.com', 'Barb', 'Benson', 'AQAAAAEAACcQAAAAEIFBROJJCnbp8/fdaAGQTDKSHVijtPWoei5Nk+GTn8fBx6hw+xTmi+Xok84MYQPAGA==')
, ('c@gmail.com', 'Cari', 'Carmon', 'AQAAAAEAACcQAAAAEGmeK5BqTcQmxdzK5D0p3FbMqQ500vmv8ILljJoltpn7XqdGunmACAJ7DQGR+WxpQg==')
, ('d@gmail.com', 'David', 'Dickenson', 'AQAAAAEAACcQAAAAEKiVbSqBMYW9tGOOjW3DRG7+r8VNvBzTtSUtB3X3ZYqPXBz3I4s4CVqonU8duySSQg==')
, ('e@gmail.com', 'Erin', 'Erikson', 'AQAAAAEAACcQAAAAEKZPQTrrcfnseR++K0iGPUrjAPlyVGAN1+q8RdQoJ0S/DtyND819CiaA3SACRk384Q==')
, ('f@gmail.com', 'Fred', 'Franklin', 'AQAAAAEAACcQAAAAENG0CQQKQj0b6AkS1xWL7dGQ2NTFtTKHSwaAyO6yHXaLPpF0s2uswSwZ3/WX5qSWMw==')
, ('g@gmail.com', 'Gary', 'Grearson', 'AQAAAAEAACcQAAAAEBKjP3SxEf2VMLUpZNBWRdmnyVfIBknfRS9UVyMH1fxzK63ksfLmIBMhhuG5FmGY7g==')
, ('h@gmail.com', 'Helen', 'Holden', 'AQAAAAEAACcQAAAAELjcTZeeo9JgixicO6/jpW2dTs9wWn6tGPJufPhdEccePlxW1GyNlC6buAOgImA//g==')
, ('i@gmail.com', 'Irene', 'Ingle', 'AQAAAAEAACcQAAAAEA7BY2bkYxnRf5Cy8Hwsyqt6+KrE+SSpInE0IR70DGsrci2m3aWVNbdhBhR9Ai3lyA==')
, ('j@gmail.com', 'Jeff', 'Jefferson', 'AQAAAAEAACcQAAAAEK8vaX1FZyd+xuN9hL/HMRqoTEUWrxqu0fs+7s2AsBlsS2ckFK8ffgHdcR5qp8Eshw==')
, ('k@gmail.com', 'Kendra', 'Kile', 'AQAAAAEAACcQAAAAEEA8N6Yh8KCCNJaYfnGsADDVZK9LZHCfl/1IvdAzYQTXc/AdTFscpcWYvW/cz8ECTw==')
, ('l@gmail.com', 'Larry', 'Lind', 'AQAAAAEAACcQAAAAEH4UUbVx5WA+NBxXuaggv3zgP2NoNWHubcD9YxM321cs1AOxaKn/ZVQiWpofIp0PCg==')
, ('m@gmail.com', 'Mary', 'Meadows', 'AQAAAAEAACcQAAAAEDqeRYtOCGI2oNmIgZb1DtGc73QfcAC/0SRrcj2XEO4DWDGAqn4hxmjRY92ymYcxew==')
, ('n@gmail.com', 'Neal', 'Nickerson', 'AQAAAAEAACcQAAAAEDzGVEiLFpDPt6ZCyL8S4QboeAWw4959r3MPHJRWhenMOOiaQdBsDwP/RK3I9NYnlw==');


INSERT INTO weddings (CreatorUserId, WedderOneUserId, WedderTwoUserId, WeddingDate, Address) VALUES
  (14, 1, 2, '2019-06-01', '1715 114th Ave SE #100, Bellevue, WA 98004')  -- Neal, Andy & Barb
, (14, 3, 4, '2019-07-01', '213 W Institute Pl #610, Chicago, IL 60610')  -- Neal, Cari & David
, (14, 5, 6, '2019-08-01', '175 E Olive Ave 3rd Floor, Burbank, CA 91502');  -- Neal, Erin & Fred

INSERT INTO guests (WeddingId, UserId) VALUES
  (1, 7)  -- Andy & Barb: Gary Grearson
, (1, 8)  -- Andy & Barb: Helen Holden
, (1, 9);  -- Andy & Barb: Irene Ingle

SELECT * FROM users;

SELECT
    weddings.WeddingId
  , CONCAT( creatorUsers.FirstName, ' ', creatorUsers.LastName) AS Creator
  , CONCAT( wedderOneUsers.FirstName, ' & ', wedderTwoUsers.FirstName) AS Wedding
  , weddings.WeddingDate
  , weddings.Address
  , weddings.CreatorUserId
  , weddings.WedderOneUserId
  , weddings.wedderTwoUserId
  , weddings.CreatedAt
  , weddings.UpdatedAt
  FROM weddings
  INNER JOIN users creatorUsers on creatorUsers.UserId = weddings.CreatorUserId
  INNER JOIN users wedderOneUsers on wedderOneUsers.UserId = weddings.WedderOneUserId
  INNER JOIN users wedderTwoUsers on wedderTwoUsers.UserId = weddings.WedderTwoUserId;

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

