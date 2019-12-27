using Infrastructure.DataBaseTables;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieRecomendation.DataPreparation
{
    public class Datapreparator :IDataPreparator
    {
        private IMovieRepository _movieRepository;
        public Datapreparator(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void Prepare()
        {
            Movie movie = new Movie();
            movie.Name = "czesc";
            _movieRepository.Add(movie);
        }
    }
}
