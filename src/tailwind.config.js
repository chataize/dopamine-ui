/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.html", "./**/*.cshtml", "./**/*.razor", "./**/*.js"],
  theme: {
    extend: {},
    screens: {
      'sm': '640px',
      'md': '768px',
      'lg': '1024px',
      'xl': '1280px',
      '-xl': { 'max': '1279px' },
      '-lg': { 'max': '1023px' },
      '-md': { 'max': '767px' },
      '-sm': { 'max': '639px' }
    }
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
    "sm:w-auto",
    "flex",
    "sm:flex",
    "md:flex",
    "lg:flex",
    "xl:flex",
    "2xl:flex",
    "space-x-4",
    "sm:space-x-4",
    "md:space-x-4",
    "lg:space-x-4",
    "xl:space-x-4",
    "2xl:space-x-4",
    "space-y-4",
    "sm:space-y-4",
    "md:space-y-4",
    "lg:space-y-4",
    "xl:space-y-4",
    "2xl:space-y-4",
  ],
  future: {
    hoverOnlyWhenSupported: true,
  }
}
