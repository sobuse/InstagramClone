Instagram Clone Application

```Mermaid
erDiagram

    User |{--o{Post:Place
    Post ||--|{PostReaction: contains
    User}|--|{UserFollower: uses
    User{
       Guid Id
       string email
       string password
       string firstName
       string lastName
       string Avatar
       dateTime createdDate
    }

    UserFollower{
        Guid followerUserId
        Guid FollowerId
        dateTime craetedDate
    }

    Post{
        Guid Id
        string content
        dateTime createddate
        User author
    }



    PostReaction{
        Post post
        Guid Id
        User author
        int type
        dateTime createdDate
    }

```
