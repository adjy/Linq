namespace Linq {
    public static class LinqTD {
        /**
		 * Cette fonction doit filtrer la séquence pour ne garder que les entrées commencant par une
		 * lettre fournie en parametre
		 */
        public static IEnumerable<string> FilterElementsBeginningWithSpecificLetter(IEnumerable<string> sequence, char letter) {
            throw new NotImplementedException();
        }

        /**
		 * Cette fonction doit retourner le premier element de la séquence de la taille fournie en parametre
		 */
        public static string? FirstElementOfLengthI(IEnumerable<string> sequence, int size) {
            throw new NotImplementedException();
        }

        /**
		 * Cette fonction doit retourner la moyenne de la séquence fournie en paramètre
		 */
        public static double AverageOfSequence(IEnumerable<int> intSequence) {
            throw new NotImplementedException();
        }

        /**
		 * Cette fonction doit retourner la moyenne des éléments uniques (sans les duplications) de la séquence fournie en paramètre
		 */
        public static double AverageOfUniqueSequenceElements(IEnumerable<int> intSequence) {
            throw new NotImplementedException();
        }

        /**
		 * Cette fonction doit retourner un tuple (min, max) de la séquence
		 */
        public static (int, int) MinMaxOfSequence(IEnumerable<int> intSequence) {
            throw new NotImplementedException();
        }

        /**
		 * Cette fonction doit retourner la liste des ids des objets de la séquence
		 */
        public static IEnumerable<int> IdsListOfSequence(IEnumerable<DummyModel> objectSequence) {
            throw new NotImplementedException();
        }

        /**
		 * Cette fonction retourne l'age moyen dans la séquence pour les objets non supprimés
		 */
        public static double AgeAverageOfSequence(IEnumerable<DummyModel> objectSequence) {
            throw new NotImplementedException();
        }

        /**
		 * Cette fonction retourne vrai si l'un des membres dans la séquence a un age egal à celui donné en paramètres
		 */
        public static bool DoesSomeonesHasASpecificAge(IEnumerable<DummyModel> objectSequence, int age) {
            throw new NotImplementedException();
        }
    }
}
