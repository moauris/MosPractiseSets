using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MosPracWebApp.Models
{
    public static class SeedData
    {
        public static void InitQuestionData(this IApplicationBuilder app)
        {
            DataContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<DataContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Questions.Any() && !context.QuestionSets.Any())
            {
                QuestionSet qsAzurePart1 = new QuestionSet
                {
                    Name = "Azure Fundamentals Part 1",
                    Description = "Describe core Azure Concepts",
                    Topics = new List<Topic> { 
                        new Topic("Cloud"),
                        new Topic("Azure"),
                        new Topic("DevOps") 
                    }
                };

                List<Question> qAzurePart1 = new List<Question>
                {
                    new Question
                    {
                        Name = "What does cloud computing offer",
                        Description = "Select the option that describe benefits cloud computing has to offer to businesses.",
                        Options = new List<Option>{
                            new Option("faser innovation, flexible resources, and economies of scale"),
                            new Option("Invulunablity to cyber attacks, dynamic interpersonal interactions"),
                            new Option("Complete overhaul of organizational structure"),
                            new Option("Advanced AI facilitated computing which renders human assets obsolete")
                        }
                    },
                    new Question
                    {
                        Name = "Cloud Advantage Reliability",
                        Description = "Which of the below descibe the Reliability advantage in cloud computing?",
                        Options = new List<Option>{
                            new Option("Depending on the Service-Level agreement, the cloud-based application can provide a continuous user experience"),
                            new Option("Grants 100% guarantee against all cyber attacks and security issues"),
                            new Option("Provides up to 80% of up time to ensure a smooth user experience"),
                            new Option("Make sure that the local IT assets of the company runs 24x7 without any noticeable downtime or interrupts.")
                        }
                    },
                    new Question
                    {
                        Name = "Cloud Advantage Scalability",
                        Description = "Which of the below descibe the Scalability advantage in cloud computing?",
                        Options = new List<Option>{
                            new Option("With increasing demands, the applications can scale vertically by adding more resources to a single VM, or horizontally, by adding more instances of VM"),
                            new Option("Cloud-based applications can expand and shrink"),
                            new Option("Cloud-based services and applications can be automatically configured to use only the resources and VMs that the applications really need"),
                            new Option("Cloud-based applications and be deployed to regional datacenters around the globe, so that the customers in different regions can always have the best performance")
                        }
                    },
                    new Question
                    {
                        Name = "Cloud Advantage Disaster Recovery",
                        Description = "Which of the below descibe the Disaster Recovery advantage in cloud computing?",
                        Options = new List<Option>{
                            new Option("With cloud-based backup services, data replication, and geo-distribution, your data is safe in the event of disasters"),
                            new Option("Microsoft provide state of the art fire fighting equipments such as water sprinklers in their cloud data centers as standard"),
                            new Option("Azure Onsite Experts will manually back up your data and VM states periodically, as well as performing health checks for the data center"),
                            new Option("Cloud-based applications and be deployed to regional datacenters around the globe, so that the customers in different regions can always have the best performance")
                        }
                    }
                };

                qsAzurePart1.Questions = qAzurePart1;

                context.QuestionSets.Add(qsAzurePart1);
                context.Questions.AddRange(qAzurePart1);
                context.SaveChanges();
            }

        }
    }
}
