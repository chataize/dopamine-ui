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
    "sm:w-auto"
  ],
  future: {
    hoverOnlyWhenSupported: true,
  }
}
