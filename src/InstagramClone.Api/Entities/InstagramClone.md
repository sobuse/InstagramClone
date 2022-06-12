Instagram Clone Application

```mermaid
erDiagram

    User |{--o{Post:Place
    Post ||--|{PostReaction: contains
    User}|--|{UserFollower: uses
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
        Guid FollowerUserId
        Guid FollowerId
        dateTime CraetedDate
    }

    Post{
        Guid Id
        string Content
        dateTime Createddate
        User Author
    }



    PostReaction{
        Post post
        Guid Id
        User Author
        int Type
        dateTime CreatedDate
    }

```
