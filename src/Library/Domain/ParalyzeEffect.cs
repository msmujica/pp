namespace Library
{
    /// <summary>
    /// Clase que representa el efecto de "paralizar" a un Pokémon.
    /// Un Pokémon paralizado tiene un 30% de probabilidad de no poder atacar en cada turno.
    /// </summary>
    public class ParalyzeEffect : IEffect
    {
        public bool PuedoAtacar { get; set; }
        /// <summary>
        /// Inicia el efecto de "paralizar" en el Pokémon.
        /// Este efecto impide que el Pokémon pueda atacar con una probabilidad.
        /// </summary>
        /// <param name="pokemon">El Pokémon que será paralizado.</param>
        public string IniciarEfecto(Pokemon pokemon)
        {
            return $"El pokemon {pokemon.Name} se le aplico el efecto paralisis.";
        }

        /// <summary>
        /// Procesa el efecto de la parálisis en el turno de un Pokémon.
        /// Determina si el Pokémon puede o no atacar en el turno actual debido a la parálisis.
        /// </summary>
        /// <param name="pokemon">El Pokémon que está bajo el efecto de parálisis.</param>
        /// <returns>
        /// <c>true</c> si el efecto sigue activo (es decir, el Pokémon no ha atacado debido a la parálisis).
        /// <c>false</c> si el Pokémon ha superado la parálisis y puede atacar.
        /// </returns>
        public string ProcesarEfecto(Pokemon pokemon)
        {
            if (this.PuedoAtacar)
            {
                // El Pokémon puede atacar este turno.
                return $"El pokemon {pokemon.Name} supera la parálisis en este turno y puede atacar.";
                // El efecto continúa, ya que el Pokémon puede atacar.
            }
            
            // El Pokémon no puede atacar este turno debido a la parálisis.
            return $"{pokemon.Name} está paralizado y no puede atacar, perdiste el turno.";
            // El efecto sigue activo, ya que el Pokémon no puede atacar.
        }

        /// <summary>
        /// Determina si el Pokémon puede atacar o no debido a la parálisis.
        /// Hay un 70% de probabilidad de que el Pokémon pueda atacar.
        /// </summary>
        /// <returns>
        /// <c>true</c> si el Pokémon puede atacar (70% de probabilidad).
        /// <c>false</c> si el Pokémon no puede atacar (30% de probabilidad).
        /// </returns>
        private bool PuedeAtacar()
        {
            // Genera un número aleatorio para determinar si puede atacar
            // Hay un 30% de probabilidad de que el Pokémon no pueda atacar.
            this.PuedoAtacar = new Random().NextDouble() > 0.3;
            return this.PuedoAtacar;
        }
    }
}