const withPlugins = require("next-compose-plugins");

const withBundleAnalyzer = require("@next/bundle-analyzer")({
    enabled: process.env.ANALYZE === "true",
});

const nextTranslate = require("next-translate");

const config = {};

module.exports = withPlugins([[withBundleAnalyzer], [nextTranslate]], config);
