TODO: 
- [x] relations (1 to n all tables with connectDB)
- [x] comments (for easier documentation)
- [ ] table for users 
- [ ] normalization (if needed)


```
CREATE DATABASE LyricsWorld
GO;
USE LyricsWorld;
-- create table artists
CREATE TABLE dbo.Artists
	(
	ArtistID int IDENTITY(1,1) NOT NULL,
	ArtistName nvarchar(50) NOT NULL,
	ArtistDescription nvarchar(MAX) NULL,
	ArtistPhoto varchar(MAX) NULL,
	ArtistPopularity int DEFAULT 0,
	CONSTRAINT PK_ArtistsID PRIMARY KEY CLUSTERED (ArtistID)
	);

-- create table songs
CREATE TABLE dbo.Songs
	(
	SongID int IDENTITY(1,1) NOT NULL,
	SongTitle nvarchar(50) NOT NULL,
	SongDuration int NOT NULL,
	SongLyrics nvarchar(MAX) NOT NULL,
	CONSTRAINT PK_SongID PRIMARY KEY CLUSTERED (SongID)
	);
-- create table albums
CREATE TABLE dbo.Albums
	(
	AlbumID int IDENTITY(1,1) NOT NULL ,
	AlbumTitle nvarchar(50) NOT NULL,
	DateAdded date NOT NULL,
	AlbumCover nvarchar(MAX) NULL,
	AlbumType varchar(20) NOT NULL,
	CONSTRAINT PK_AlbumID PRIMARY KEY (AlbumID)
	);
-- create table to connect other 3
CREATE TABLE dbo.ConnectDB
	(
	IDalbum int NOT NULL,
	IDartist int NOT NULL,
	IDsong int NOT NULL,
	CONSTRAINT FK_IDalbumToAlbum FOREIGN KEY (IDalbum) REFERENCES dbo.Albums(AlbumID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_IDartistToArtist FOREIGN KEY (IDartist) REFERENCES dbo.Artists(ArtistID) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_IDsongToSongs FOREIGN KEY (IDsong) REFERENCES dbo.Songs(SongID) ON DELETE CASCADE ON UPDATE CASCADE
	);
	
-- add all dro kenjis albums
INSERT INTO dbo.Albums(AlbumTitle,AlbumCover,AlbumType,DateAdded) VALUES ('WISH YOU WERE HERE','none','album','2023-08-18'), ('ANYWHERE BUT HERE','none','album','2022-08-26'),('LOST IN HERE','none','EP','2022-08-05'),
('WITH OR WITHOUT YOU','none','album','2022-01-28'),('F*CK YOUR FEELINGS','none','album','2021-06-18'),('EAT YOUR HEART OUT','none','album','2021-02-26'),('RACE ME TO HELL','none','album','2020-12-25'),
('TEARS AND PISTOLS','none','album','2020-11-13');

-- add dro kenji
INSERT INTO dbo.Artists ([ArtistName],[ArtistDescription],[ArtistPhoto]) VALUES ('DroKenji','Daniel Jerome Jenrette (born January 11, 2002), known professionally as Dro Kenji , is an American rapper and singer from Summerville, South Carolina. He is currently signed to Internet Money Records and 10K Projects. In 2019, at the age of 17, Dro Kenji started rapping.','none');
-- add dc the don
INSERT INTO [dbo].[Artists] ([ArtistName],[ArtistDescription],[ArtistPhoto]) VALUES ('DC The Don','Daijon Cotty Davis (born August 3, 1999), known professionally as DC the Don, is an American rapper, singer, and songwriter from Milwaukee, Wisconsin. He is recognized for mixing elements of hip-hop, rock, and melodic rap in his music.','none');

INSERT INTO dbo.Songs([SongTitle],[SongDuration],[SongLyrics]) VALUES ('2HIGH2TELL',160, '[Intro]|
Fuck it, I''m all alone|
|
[Chorus]|
Uh, Killjoy playin'' in my head like white noise|
Look around, point ''em out, fuck it, I''m all alone|
(Woah, oh, woah, oh, oh)|
Uh, our past played out, push it out, push it out|
Runnin'' out of time, so fuck it, I''m all alone (All alone)|
If you take my heart, don''t thrash it up|
And my head, sometimes feel bad as fuck|
Why cry? I just can''t give no fuck|
They all lie, I just can''t hear my thoughts|
Slow down, life gets sad as hell|
Oh, well, I''m too high to tell, oh, yeah|
|
[Verse 1]|
Break me out this dream, I''m in love with what you''re tellin'' me (Woah, woah, woah)|
You want me to make it clear? I''ll sing it like a melody (Ooh, woah, woah)|
Always suck this dick ''cause I''m the biggest steppin'' curr?ntly|
So shawty keep on tellin'' me she proud of m?|
|
[Chorus]|
Uh, Killjoy playin'' in my head like white noise|
Look around, point ''em out, fuck it, I''m all alone (La-da-da-da-da)|
(Fuck it, I''m all alone)|
Uh, our past played out, push it out, push it out|
Runnin'' out of time, so fuck it, I''m all alone (Oh, oh, oh, all alone)|
(Oh, oh)|
If you take my heart, don''t thrash it up|
And my head, sometimes feel bad as fuck (Oh-oh-oh)|
Why cry? I just can''t give no fuck|
They all lie, I just can''t hear my thoughts (Oh-oh-oh)|
Slow down (Ooh), life gets sad as hell (Gets sad as hell)|
Oh, well, I''m too high to tell, oh, yeah (Oh-oh-woah)|

[Verse 2]|
Stuck, lock heart, geeky high, torch (Okay)|
She a good girl, but the cash make her twerk (Oh, oh, woah)|
Heed my words, I''ma be first (Oh, yeah)|
No matter what you do, just know it always could be worse (Oh, oh, woah)|
|
[Chorus]|
Uh, Killjoy playin'' in my head like white noise|
Look around, point ''em out, fuck it, I''m all alone (Fuck it, I''m all alone)|
(Oh, oh)|
Uh, our past played out, push it out, push it out|
Runnin'' out of time (Push it out), so fuck it, I''m all alone|
(Woah, woah, woah, ah-ah-ah)|
If you take my heart, don''t thrash it up|
And my head, sometimes feel bad as fuck|
Why cry? I just can''t give no fuck|
They all lie, I just can''t hear my thoughts (Oh-oh-oh)|
Slow down (Ooh), life gets sad as hell (Ah, ah)|
Oh, well, I''m too high to tell, oh, yeah (Woah)|'),

('EUPHORIA',134,'[intro]|
(Earl on the Beat)|
|
[Chorus]|
She got hatred in her veins, but she don''t really care|
I just left my peace of mind, I fucked her good, I had lil'' shawty screamin'', "Whoo-sah!"|
And I won''t see you for a while (And I won''t see you for a while)|
When I''m down, I sing our song and sip on codeine ''til I drown (Sip on codeine ''til I drown)|
I''m a rockstar, I''m not too sure why you''re around (Sure why you''re around)|
You don''t love hard, just hardly when I come around (Just hardly when I come around)|
Just tell me you love me and that you still wantin'' to hold me forever (Forever)|
Before we end, you like euphoria (You like euphoria)|
A pleasure only in my head (A pleasure only in my head)|
|
[Verse]|
Who were we before? (Before)|
I cannot recall (Recall)|
Sometimes, I feel out of my mind (Mind)|
And I don''t have nobody to fall on (Nobody to fall on)|
I swear, you''re my most toxic memory (Memory)|
Who had my back when I had no one to lean on? (No one to lean on)|
Nobody know the lies you told but me (But me)|
Who got my back when it ain''t no one here? (No one here)|
|
[Chorus]|
She got hatred in her veins, but she don''t really care|
I just left my peace of mind, I fucked her good, I had lil'' shawty screamin'', "Whoo-sah!"|
And I won''t see you for a while (And I won''t see you for a while)|
When I''m down, I sing our song and sip on codeine ''til I drown (Sip on codeine ''til I drown)|
I''m a rockstar, I''m not too sure why you''re around (Sure why you''re around)|
You don''t love hard, just hardly when I come around (Just hardly when I come around)|
Just tell me you love me and that you still wantin'' to hold me forever (Forever)|
Before we end, you like euphoria (You like euphoria)|
A pleasure only in my head (A pleasure only in my head)|
|
[Outro]|
''Phoria|
''Phoria|
''Phoria|
''Phoria|'),

('LIE LIE LIE',247,'[Intro]|
Oh-oh-oh-uh|
Oh-oh-oh-uh (Census, what you cookin''?)|
(Perfect!)|
Oh-oh-oh-uh|
|
[Chorus]|
Love me, you''re my all|
Heart locked down, but still can''t fall|
Right now, right now|
I really need your love, lil'' bae, I know you need me when I''m never around|
Heart never around, head stuck in the clouds|
Thoughts roamin'' around, I''m really needin'' you now|
Numb hell, lie, lie, lie|
Numb hell, lie, lie, lie|
Love me, you''re my all (All)|
Heart locked down, but still can''t fall|
Right now, right now|
I really need your love, lil'' bae, I know you need me when I''m never around|
Heart never around, head stuck in the clouds|
Thoughts roamin'' around, I''m really needin'' you now|
Numb hell, lie, lie, lie|
Numb hell, lie, lie, lie|
|
[Verse 1]|
It ain''t easy to give love, baby|
No, it ain''t easy to give you love no more|
Still don''t know myself no more (Oh)|
But still be givin'' you love, oh, no, oh|
Oh, no, oh|
Oh, no, oh|
Oh, no, oh (Oh, no, no)|
Uh, lovin'' you ain''t easy, givin'' it up|
It was you that never wanted me and you to give up, do-do-do|
Smokin'' heavy, finna go up|
It''s not a worry in my mind when you be with me or by my side|
Feel like throwin'' my feelings up|
When you here with me, baby, I don''t give a fuck, you my ride or die|
But still ride|
Or die tryin''|
You all mine (Do-do-do-do)|
|
[Chorus]|
Love me, you''re my all|
Heart locked down, but still can''t fall|
Right now, right now|
I really need your love, lil'' bae, I know you need me when I''m never around|
Heart never around, head stuck in the clouds|
Thoughts roamin'' around, I''m really needin'' you now|
Numb hell, lie, lie, lie|
Numb hell, lie, lie, lie|
Love me, you''re my all (All)|
Heart locked down, but still can''t fall|
Right now, right now|
I really need your love, lil'' bae, I know you need me when I''m never around|
Heart never around, head stuck in the clouds|
Thoughts roamin'' around, I''m really needin'' you now|
Numb hell, lie, lie, lie|
Numb hell, lie, lie, lie|
|
[Verse 2]|
Finna take this shit to battle, demons standin'' on my side (Standin'' on my side)|
Not allowed to feel no happiness no more, so I don''t try|
Still, I''m fallin'' in this bottomless abyss, I don''t know why|
It''s a lot of evil around me, bought a foreign just to slide in|
Goin'' away, still runnin'' away|
Still runnin'' away, still runnin'' away (Oh-oh-woah)|
[Chorus]|
Love me, you''re my all|
Heart locked down, but still can''t fall|
Right now, right now|
I really need your love, lil'' bae, I know you need me when I''m never around|
Heart never around, head stuck in the clouds|
Thoughts roamin'' around, I''m really needin'' you now|
Numb hell, lie, lie, lie|
Numb hell, lie, lie, lie|
Love me, you''re my all (All)|
Heart locked down, but still can''t fall|
Right now, right now|
I really need your love, lil'' bae, I know you need me when I''m never around|
Heart never around, head stuck in the clouds|
Thoughts roamin'' around, I''m really needin'' you now|
Numb hell, lie, lie, lie|
Numb hell, lie, lie, lie|
|
[Outro]|
Ooh, lie|
Numb hell, lie, lie, lie|
Numb hell, lie, lie, lie|
Lie, lie, lie|
Numb hell, lie, lie, lie|
Ooh, lie, lie|'),

('ONE TIME',192,'[Intro]|
Oh-uh-uh-uh|
Ooh-uh-uh-uh|
|
[Chorus]|
Uh, be with me forever, it''ll be perfect if you stay|
The drugs been holdin'' me together like I''m finally wide awake|
It''s just me and you together in this fantasy of mine|
I can''t believe it only took one time (One time)|
I can''t believe it only took one time (One time)|
I can''t believe it only took one time (One time)|
I can''t believe it only took on? time (One time)|
I don''t think I got no mor? tries, uh (More tries)|
|
[Verse 1]|
Oh wow, I''m so sorry, I just don''t care to stay for the bullshit|
I ran up my money, looped it|
Broke whore tellin'' me rich delusions|
I know I''m not sorry, fuck it|
I''m happiest when smokin'' ruckus|
This bitch wanna take my soul and I don''t know if I can trust it|
Down for the calls, is you playin'' your role?|
I have vivid dreams of bein'' trapped inside your memories|
I''m on new Balenciaga jeans and all the pretty things|
I don''t ever-ever fall in love, so tell me why it took one time (One time)|
|
[Pre-Chorus]|
One, one time|
Can you hear me screamin'' out loud, loud, loud?|
One time|
If you adore me, tell me now, now, now, now|
|
[Chorus]|
Uh, be with me forever, it''ll be perfect if you stay|
The drugs been holdin'' me together like I''m finally wide awake|
It''s just me and you together in this fantasy of mine|
I can''t believe it only took one time (One time)|
I can''t believe it only took one time (One time)|
I can''t believe it only took one time (One time)|
I can''t believe it only took one time (One time)|
I don''t think I got no more tries, uh (More tries)|
|
[Verse 2]|
I can''t believe you let our real love die (Die, die, die)|
She can''t believe I move around this high (This high, high)|
I can''t believe the drugs don''t work no more (More, more, more)|
But I''ve been wildin'' out, so I see why (Why, why, why, why, why)|
Be with me forever like you need it everyday|
I''ve still been holdin'' on forever like we''ll never go away|
You say your heart been cold forever, that''s a vacancy in mine|
And no, I''ll never-ever go away (I can''t believe it only took one time)|
[Pre-Chorus]|
One, one time|
Can you hear me screamin'' out loud, loud, loud?|
One time|
If you adore me, tell me now, now, now, now|
|
[Chorus]|
Uh, be with me forever, it''ll be perfect if you stay|
The drugs been holdin'' me together like I''m finally wide awake|
It''s just me and you together in this fantasy of mine|
I can''t believe it only took one time (One time)|
I can''t believe it only took one time (One time)|
I can''t believe it only took one time (One time)|
I can''t believe it only took one time (One time)|
I don''t think I got no more tries, uh (More tries)|'),
('SO WHAT',182,'[Intro: Dro Kenji]|
Uh, uh|
|
[Chorus: Dro Kenji & DC The Don]|
Okay, I''m up, I''m wide awake|
I see the phony and the fake|
Niggas mad ''cause I get paper|
Cool me down|
She fuck rappers, I ain''t had to fly her to me|
Don''t run down on Lil'' Kenji, I keep big ass blickys with me (Go)|
Run down on the gang right now, all my niggas on go (Go)|
Red dot with a .556, niggas kickin'' down doors|
I got big bag rolled up, smokin'' gas, poured up (Yeah)|
He get blast, blown up (Yeah, hey, hey)|
He get blast, so what? (Go)|
|
[Verse 1: DC The Don]|
How the fuck get a new i8 with the butterfly doors? (Go, go)|
Donny fresh out of LAX with some L.A. hoes (Go, go)|
I put that shit on, lil'' bitch, I just hopped in the Phantom (Go, yeah)|
I ride with the motherfuckin'' goats (Go)|
When I''m rockin'' that green, I feel slimy as fuck (Shit)|
Danny Phantom the whip, and Dior on my coat (Yeah)|
I just step on the gas and I float (Yeah)|
My bitch, she bad, but she doin'' the most (Yeah)|
Oh, you think you a demon? This nigga a joke (Yeah)|
Aimin'' straight for you, Taliban, shoot through the floor (Go)|
Watch me make that bitch jump, jump, jump|
When I hop on the stage, they gon'' jump through the floor (Jump, shit)|
Yeah, they stay on my dick, I just go with the flow (Jump)|
We can turn the bitch up (Jump)|
We keep goin'' some more (Jump, jump, jump)|
Bitch, I got on Rick right now, what the fuck did you think? (Jump, bitch)|
Three-five in the ''wood right now, niggas smokin'' on dank (Go)|
That''s why I say I''m The Don of a Don ''cause I''m doin'' this shit, I do something he can''t (Go, go, go, ayy)|
I just bang on my chest like the Planet of the Apes|
We could slide through your hood in a big-ass tank (Go, go, go, go)|
|
[Chorus: Dro Kenji & DC The Don]|
Okay, I''m up, I''m wide awake|
I see the phony and the fake|
Niggas mad ''cause I get paper|
Cool me down|
She fuck rappers, I ain''t had to fly her to me|
Don''t run down on Lil'' Kenji, I keep big ass blickys with me (Go)|
Run down on the gang right now, all my niggas on go (Go)|
Red dot with a .556, niggas kickin'' down doors|
I got big bag rolled up, smokin'' gas, poured up (Yeah)|
He get blast, blown up (Yeah, hey, hey)|
He get blast, so what? (Go)|
|
[Verse 2: Dro Kenji]|
Like, I get so damn high, I think I seen an AC-130|
I fucked that bitch one time and blocked her ''cause I can''t love on birdies|
I''m in my private section, peace out and her friends all came with me|
This lil'' Taurus pistol on me, ain''t for violence, it''s for peace when I''m outside|
I just seen a opp nigga tryna switch sides|
I can''t fuck you for the free, the bitch out of her mind|
Money what I need, let''s say it one more time (Let''s go, okay)|
Big bag, stripper ass, I had a dream like Martin Luther|
A hundred fuckin'' money bags, I''ll add that shit up, fuck a tutor|
Money what I need, let''s say it one more time|
Money what I need, let''s say it one more time (Let''s go)|
[Chorus: Dro Kenji & DC The Don]|
Okay, I''m up, I''m wide awake|
I see the phony and the fake|
Niggas mad ''cause I get paper|
Cool me down|
She fuck rappers, I ain''t had to fly her to me|
Don''t run down on Lil'' Kenji, I keep big ass blickys with me (Go)|
Run down on the gang right now, all my niggas on go (Go)|
Red dot with a .556, niggas kickin'' down doors|
I got big bag rolled up, smokin'' gas, poured up (Yeah)|
He get blast, blown up (Yeah, hey, hey)|
He get blast, so what? (Go, go)|
|
[Outro: Dro Kenji]|
Okay, I''m up, I''m wide awake|
I see the phony and the fake|
Niggas mad ''cause I get paper|
Cool me down|
She fuck rappers, I ain''t had to fly her to me|
Don''t run down on Lil'' Kenji, I keep big ass blickys|');

-- add some info to connectdb
INSERT INTO [dbo].[ConnectDB] VALUES (3,1,1), (3,1,2),(3,1,3),(3,1,4),(3,1,5),(3,2,5);

```

join 
```
SELECT AlbumTitle, AlbumID, SongTitle, SongID, ArtistName, ArtistID FROM dbo.Albums JOIN dbo.ConnectDB ON dbo.Albums.AlbumID=dbo.ConnectDB.IDalbum JOIN dbo.Songs ON 
dbo.Songs.SongID=dbo.ConnectDB.IDsong JOIN dbo.Artists ON dbo.Artists.ArtistID=dbo.ConnectDB.IDartist
```


INSERT INTO [dbo].[Songs] ([SongTitle],[SongDuration],[SongLyrics]) VALUES ('2HIGH2TELL', 160, '\

