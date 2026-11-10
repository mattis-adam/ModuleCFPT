/**
 * Règle de validation d'une carte de paiement de la boutique Parankoka.
 * Retourne un objet : { accepte: bool, message: string }.
 */
export function validateCard(numero, mois, annee, cvv) {
  return { accepte: false, message: "" };
}
