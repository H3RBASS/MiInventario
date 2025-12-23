// tailwind.config.js
module.exports = {
  content: [
    "./**/*.{razor,html,cshtml}",
    "./**/*.{razor,html}",
    "./*.html",
    "./Pages/**/*.razor",
    "./Components/**/*.razor",
    "./Shared/**/*.razor",
    "./wwwroot/**/*.html"
  ],
  theme: {
    extend: {
        colors: {
            'negro': '#191b1d',
            'negro-semiclaro': '##3b4042',
            'verde': '#0bb688',
            'GrisSemiclaro': '#f3f3f3',
            
        }
    }
  }
}