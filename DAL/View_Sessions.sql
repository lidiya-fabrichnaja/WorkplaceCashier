CREATE VIEW [dbo].[View_Sessions]
AS
SELECT U.Name AS UserName, B.Name AS CashBoxPlace, B.Number AS CashBoxNumebr, S.ID AS SessionNumebr, S.BeginDate, S.EndDate, S.Sum, COUNT(*) AS CheckCount
FROM     dbo.Sessions AS S INNER JOIN
                  dbo.Users AS U ON U.ID = S.UserID INNER JOIN
                  dbo.CashBoxes AS B ON B.ID = S.CashBoxID INNER JOIN
                  dbo.Checks AS C ON C.SessionID = S.ID
GROUP BY U.Name, B.Name, B.Number, S.ID, S.BeginDate, S.EndDate, S.Sum;

