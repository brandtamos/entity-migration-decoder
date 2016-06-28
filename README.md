"# entity-migration-decoder" 

This program accepts a Base64 gzipped string as input. 

It's main purpose is to decode Entity Migrations to view the EDMX file generated from automatic migrations.

Below is a useful SQL query for pulling the data out of your DB:

declare @binaryContent varbinary(max);

select @binaryContent = Model
from [dbo].[__MigrationHistory]
where migrationId = 'MIGRATION_ID_HERE'

select cast('' as xml).value('xs:base64Binary(sql:variable("@binaryContent"))',
'varchar(max)') as base64Content

Note that you may need to export the result to a csv, as a result that is too long will get cut off in SQL Management Studio.