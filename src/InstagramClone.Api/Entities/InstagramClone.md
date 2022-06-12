Instagram Clone Application

```mermaid
erDiagram

    User |{--o{Post:has
    Post ||--|{PostReaction: has 
    User}|--|{UserFollower: isFolloweredBy 
    User{
       Guid Id
       string Email
       string Password
       string FirstName
       string LastName
       string Avatar
       DateTime CreatedDate
    }

    UserFollower{
        User FollowerUserId
        User FollowerId
        DateTime CreatedDate
    }

    Post{
        Guid Id
        string Content
        DateTime Createddate
        Guid AuthorId
    }

    PostReaction{
        Guid Id
        User AuthorId
        int Type
        DateTime CreatedDate
    }

```
