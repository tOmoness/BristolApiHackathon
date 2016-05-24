using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface IDirections
    {
        DirectionsResponse Get(DirectionsRequest directionsRequest);
    }
}