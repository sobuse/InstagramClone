Instagram Clone Application

```mermaid
erDiagram

    User |{--o{Post:has
    Post ||--|{PostReaction: isFolloweredBy 
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
