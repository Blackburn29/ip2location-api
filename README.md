# IP2Location API Service
A simple API for IP Geo-Location lookups against an IP2Location database.

## Usage
The API contains a single endpoint for IPv4 lookups.

`/api/lookup?ip=xxx.xxx.xxx.xxx`  
Returns `200` on success, `401` on invalid IP address or format.

```bash
200 OK
{
    id: 1,
    ipFrom: 0,
    ipTo: 4294967296,
    countryCode: "-",
    countryName: "-",
    region: "-",
    city: "-",
    latitude: 0,
    longitude: 0,
    zipCode: "-",
    timeZone: "-",
    ispName: "-",
    domainName: "-"
}
```

## Installation
- This API requires a populated IP2Location database. There are many ways to achieve this, however
IP2Location does have a helpful docker image that contains a populated database instance
[HERE](https://hub.docker.com/r/ip2location/mysql)  
__(Please note that the schema for the database in this project requires an `id` column, where the IP2Location database does not.)__

- A docker image of this service is also available via the docker registry
[blackburn29/ip2location-api](https://hub.docker.com/r/blackburn29/ip2location-api)

- Override the `ConnectionStrings:DatabaseConnection` parameter to point to your MySQL database instance.  
(Docker ENV `CONNECTIONSTRINGS__DATABASECONNECTION=""`)

