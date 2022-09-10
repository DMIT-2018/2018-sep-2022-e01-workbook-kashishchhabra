<Query Kind="Expression">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c12aaaaa</ID>
    <NamingService>2</NamingService>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\ChinookDemoDb.sqlite</AttachFileName>
    <DisplayName>Demo database (SQLite)</DisplayName>
    <DriverData>
      <PreserveNumeric1>true</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.Sqlite</EFProvider>
      <MapSQLiteDateTimes>true</MapSQLiteDateTimes>
      <MapSQLiteBooleans>true</MapSQLiteBooleans>
    </DriverData>
  </Connection>
</Query>

//sorting 
//there is a significant difference between query syntax and method syntax
//query syntax is much like sql
//orderby field {[ascending]|[descending],[field ...]}
//ascending is the default option
//method syntax is a series of individual methods
//.OrderBy(x => x.field)
//.OrderByDescending (x=> x.field)
//.ThenBy (x => x.field)
//.ThenByDescending (x => x.field)

//find all the tracks of the album for the band queen . order the tracks by the track name alphabatically


//query syntax method

from x in Tracks
where x.Album.Artist.Name.Contains("Queen")
orderby x.AlbumId, x.Name
select x

//method syntax

Tracks
 .OrderBy (x => x.Album.Title)
 .ThenBy (x => x.Name)
 .Where (x => x.Album.Artist.Name.Contains("Queen"))
 