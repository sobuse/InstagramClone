Instagram Clone Application

```mermaid
erDiagram

    User |{--o{Post:Has
    Post ||--|{PostReaction: Creates 
    User}|--|{UserFollower: Has 
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
        User AuthorId
    }

    PostReaction{
        Post post
        Guid Id
        User AuthorId
        int Type
        dateTime CreatedDate
    }

```
