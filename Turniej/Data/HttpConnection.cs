using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tournament
{
    class HttpConnection
    {
        static HttpClient client = new HttpClient();
        public HttpConnection()
        {
            client.BaseAddress = new Uri("https://localhost:44384/api/");
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Uri> CreateTeam(TeamForCreation team)
        {
            var response = await client.PostAsJsonAsync("v1.0/teams", team);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        public List<Team> GetTeams()
        {
            List<Team> teams = null;

            var response = client.GetAsync("v1.0/teams").Result;

            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            teams = JsonConvert.DeserializeObject<List<Team>>(jsonString.Result);

            return teams;
        }

        public Team GetTeam(Guid teamId)
        {
            Team team = null;

            var response = client.GetAsync("v1.0/teams/" + teamId).Result;

            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            team = JsonConvert.DeserializeObject<Team>(jsonString.Result);

            return team;
        }

        public List<Group> GetGroups()
        {
            List<Group> groups = null;

            var response = client.GetAsync("v1.0/groups").Result;

            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            groups = JsonConvert.DeserializeObject<List<Group>>(jsonString.Result);

            return groups;
        }

        public async Task<Uri> CreateGroup(Group group)
        {
            var response = await client.PostAsJsonAsync("v1.0/groups", group);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        public async Task<Team> UpdateTeamAsync(Team team)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
            $"v1.0/teams/{team.Id}", team);
            response.EnsureSuccessStatusCode();

            //Deserialize the updated product from the response body.
            team = await response.Content.ReadAsAsync<Team>();
            return team;
        }
        public async Task<HttpStatusCode> DeleteTeamAsync(Guid id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"v1.0/teams/{id}");
            return response.StatusCode;
        }
    }
}
