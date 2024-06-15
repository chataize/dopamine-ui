/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.html", "./**/.cshtml", "./**/*.razor"],
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
      '-sm': { 'max': '639px' },
    }
  },
  plugins: [],
}
