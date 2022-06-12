Instagram Clone Application

```mermaid
erDiagram

    User |{--o{Post:has
    Post ||--|{PostReaction: creates 
    User}|--|{UserFollower: has 
    User{
       Guid Id
       string Email
       string Password
       string FirstName
       string LastName
       string Avatar
       dateTime CreatedDate
    }

    UserFollower{
        User FollowerUserId
        User FollowerId
        dateTime CreatedDate
    }

    Post{
        Guid Id
        string Content
        dateTime Createddate
        Guid AuthorId
    }

    PostReaction{
        Guid Id
        User AuthorId
        int Type
        DateTime CreatedDate
    }

```
