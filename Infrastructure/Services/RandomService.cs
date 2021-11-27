using Core.Interfaces;

namespace Infrastructure.Services
{
    public class RandomService: IRandomService
    {
        public RandomService()
        {
            // initialize attributes from the service here via dependency injection
        }

        /// <summary>
        /// function that returns 'Hello', example of a service
        /// </summary>
        /// <returns></returns>
        public string GetRandom() => "Hello";

        /// <summary>
        ///     returns string 'Hello' with id appended to it (id is from request)
        /// </summary>
        /// <param name="id"> id param from request </param>
        /// <returns> 'Hello' string with appended id </returns>
        public string GetRandomById(int id) => $"Hello {id}";

    }
}
