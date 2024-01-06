using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


[ServiceContract]
public interface IService
{
    [OperationContract]
    [WebGet(UriTemplate = "WD?x={url}", ResponseFormat = WebMessageFormat.Json)]   
    string WebDownload(string url);

    [OperationContract]
    [WebGet(UriTemplate = "WF?x={str}", ResponseFormat = WebMessageFormat.Json)]
    string WordFilter(string str);

    [OperationContract]
    [WebGet(UriTemplate = "NUM?x={num}", ResponseFormat = WebMessageFormat.Json)]
    string RandomUserNameGenerator(int num);


    [OperationContract]
    [WebGet(UriTemplate = "REG?x={teamName}&y={email}&z={usernames}", ResponseFormat = WebMessageFormat.Json)]
    string Registration(string teamName, string email, string usernames);

    [OperationContract]
    [WebGet(UriTemplate = "SEED?x={team1}&y={team2}&z={team3}&a={team4}&b={team5}&c={team6}&d={team7}&e={team8}", ResponseFormat = WebMessageFormat.Json)]
    string Seeding(string team1, string team2, string team3, string team4, string team5, string team6, string team7, string team8);

}

