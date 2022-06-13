Instagram Clone Application

```mermaid
erDiagram

    User ||--o{Post:has
    Post ||--o{PostReaction: has 
    User||--o{UserFollower: isFollowedBy 
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
        Guid FollowerUserId
        Guid FollowerId
        DateTime CreatedDate
    }

    Post{
        Guid Id
        string Content
        DateTime CreatedDate
        Guid AuthorId
    }


    PostReaction{
        Guid Id
        Guid PostId
        Guid AuthorId
        int Type
        DateTime CreatedDate
    }

```
