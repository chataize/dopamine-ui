/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.html", "./**/*.cshtml", "./**/*.razor", "./**/*.js"],
  theme: {
    extend: {},
  },
  plugins: [],
  safelist: [
    "hidden",
    "sm:hidden",
    "md:hidden",
    "lg:hidden",
    "xl:hidden",
    "2xl:hidden",
    "block",
    "sm:block",
    "md:block",
    "lg:block",
    "xl:block",
    "2xl:block",
    "sm:w-auto"
  ]
}
