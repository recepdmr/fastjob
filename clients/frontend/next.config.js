const withPlugins = require("next-compose-plugins");

const withBundleAnalyzer = require("@next/bundle-analyzer")({
    enabled: process.env.ANALYZE === "true",
});

const nextTranslate = require("next-translate");

const config = {
    future: {
        webpack5: true,
      }
};

module.exports = withPlugins([[withBundleAnalyzer], [nextTranslate]], config);
