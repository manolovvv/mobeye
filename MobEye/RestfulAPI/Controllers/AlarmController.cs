﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestfulAPI.Database;
using RestfulAPI.Models;

namespace RestfulAPI.Controllers
{
    [Route("api/messages/")]
    [ApiController]
    public class AlarmController : ControllerBase
    {
        private readonly AlarmContext alarmContext;

        public AlarmController(AlarmContext alarmContext)
        {
            this.alarmContext = alarmContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alarm>>> GetAlarms()
        {
            return await alarmContext.Alarms.Include(alarm => alarm.Recipients).ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<Alarm>> PostAlarm(AlarmPostModel alarm)
        {
            alarmContext.Alarms.Add(alarm);
            await alarmContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAlarms), new { id = alarm.MessageID }, (Alarm)alarm);
        }
    }
}
