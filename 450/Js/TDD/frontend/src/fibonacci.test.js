import { Fibonacci } from "./fibonacci.js";
import { test, expect } from "vitest";

test("GetValue_Zero_RetourneZero", () => {
  // Arrange
  const fb = new Fibonacci();
  const resultatAttendu = 0;

  // Act
  const resultatObtenu = fb.GetValue(0);

  // Assert
  expect(resultatObtenu).toBe(resultatAttendu);
});

// Décommentez ce test quand le précédent est vert, pas avant.
test("GetValue_Un_RetourneUn", () => {
  // Arrange
  const fb = new Fibonacci();
  const resultatAttendu = 1;

  // Act
  const resultatObtenu = fb.GetValue(1);

  // Assert
  expect(resultatObtenu).toBe(resultatAttendu);
});


// Décommentez ce test quand le précédent est vert, pas avant.
test("GetValue_Deux_RetourneUn", () => {
  // Arrange
  const fb = new Fibonacci();
  const resultatAttendu = 1;

  // Act
  const resultatObtenu = fb.GetValue(2);

  // Assert
  expect(resultatObtenu).toBe(resultatAttendu);
});


//Décommentez ce test quand le précédent est vert, pas avant.
test("GetValue_Trois_RetourneDeux", () => {
  // Arrange
  const fb = new Fibonacci();
  const resultatAttendu = 2;

  // Act
  const resultatObtenu = fb.GetValue(3);

  // Assert
  expect(resultatObtenu).toBe(resultatAttendu);
});


/* Décommentez ce test quand le précédent est vert, pas avant.
test.each([
  [6, 8],
  [10, 55],
  [12, 144],
  [15, 610],
])("GetValue_NombreQuelconque_RetourneFibonacci (%i, %i)", (n, resultatAttendu) => {
  // Arrange
  const fb = new Fibonacci();

  // Act
  const resultatObtenu = fb.GetValue(n);

  // Assert
  expect(resultatObtenu).toBe(resultatAttendu);
});
*/
