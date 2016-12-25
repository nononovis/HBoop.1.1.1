var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.Comment.insert(
    [
        {
            "_id": objectId("000000000000000000000000"),
            "Title": "XXXXXX",
            "IsCompleted": true,
            "LastUpdated": new Date(1369098122000)
        },
        {
            "_id": objectId("000000000000000000000001"),
            "Title": "XXXXXX",
            "IsCompleted": true,
            "LastUpdated": new Date(1369098122000)
        }
    ]);