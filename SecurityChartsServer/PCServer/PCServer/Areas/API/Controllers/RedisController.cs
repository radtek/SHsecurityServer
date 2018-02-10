﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SHSecurityContext.IRepositorys;
using SHSecurityModels;
using System.Text;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Collections.Concurrent;
using PCServer.Redis;

namespace SHSecurityServer.Controllers
{
    //[Produces("application/json")]
    //[Route("api/redistest")]
    //public class RedisController : Controller
    //{
    //    //private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
    //    //{
    //    //    return ConnectionMultiplexer.Connect("127.0.0.1:6379,abortConnect=false");
    //    //});

    //    //public static ConnectionMultiplexer Connection
    //    //{
    //    //    get
    //    //    {
    //    //        return lazyConnection.Value;
    //    //    }
    //    //}

    //    private readonly ILogger _logger;

    //    private readonly IDatabase RedisDb;

    //    //private static string Table = "Test";

    //    private readonly IConfiguration _config;

    //    public RedisController(IConfiguration config, ILogger<RedisController> logger)
    //    {

    //        _config = config;

    //        _logger = logger;

    //        //RedisDb = GetRedisDatabase();

    //        RedisDb = RedisClientSingleton.GetInstance(_config).GetDatabase("Redis_Default");


    //        //RedisDb = Connection.GetDatabase();

    //        //if (RedisDb.IsConnected(Table) && (!RedisDb.KeyExists(Table) || !RedisDb.KeyType(Table).Equals(RedisType.List)))
    //        //{
    //        //    RedisDb.KeyDelete(Table);
    //        //    RedisDb.ListRightPush(Table, "A");
    //        //    RedisDb.ListRightPush(Table, "B");
    //        //    RedisDb.ListRightPush(Table, "C");
    //        //    RedisDb.ListRightPush(Table, "D");
    //        //}
    //    }

    //    [HttpGet("{Table}", Name = "redislist")]
    //    public IActionResult Get(string table)
    //    {
    //        List<string> list = new List<string>();
    //        if (RedisDb.IsConnected(table))
    //        {
    //            long length = RedisDb.ListLength(table);
    //            list = RedisDb.ListRange(table, 0, length).Select(o => (string)o).ToList();
    //        }
    //        return Ok(list);
    //    }
    //    [HttpPost("{Table}")]
    //    public IActionResult Post(string table,[FromBody]string value)
    //    {
    //        if (value == null || !ModelState.IsValid)
    //            return BadRequest();

    //        RedisDb.ListRightPush(table, value);

    //        return Ok(value);
    //    }
    //    [HttpDelete("{value}")]
    //    public IActionResult Delete(string table,string value)
    //    {
    //        if (RedisDb.IsConnected(table))
    //        {
    //            RedisDb.ListRemove(table, value);
    //        }
    //        return Ok(value);
    //    }
    //}
}
