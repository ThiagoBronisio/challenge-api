﻿namespace ChallengeHackathon.Configs
{
    public class CORSConfig
    {
        public static string PolicyName => "DefaultPolicy";

        public static void Configure(IServiceCollection services)
        {
            services.AddCors(cfg => cfg.AddPolicy(PolicyName, builder =>
            {
                builder.WithOrigins("http://localhost:5062/")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            }));
        }
    }
} 
