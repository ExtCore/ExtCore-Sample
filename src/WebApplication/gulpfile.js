var gulp = require("gulp");

gulp.task(
  "copy-extensions", function (cb) {
    gulp.src(["../../artifacts/bin/WebApplication.ExtensionA/Debug/dnxcore50/WebApplication.ExtensionA.dll"]).pipe(gulp.dest("../../artifacts/bin/Extensions"));
    gulp.src(["../../artifacts/bin/WebApplication.ExtensionB/Debug/dnxcore50/WebApplication.ExtensionB.dll"]).pipe(gulp.dest("../../artifacts/bin/Extensions"));
    gulp.src(["../../artifacts/bin/WebApplication.ExtensionB.Data.Abstractions/Debug/dnxcore50/WebApplication.ExtensionB.Data.Abstractions.dll"]).pipe(gulp.dest("../../artifacts/bin/Extensions"));
    gulp.src(["../../artifacts/bin/WebApplication.ExtensionB.Data.EntityFramework.Sqlite/Debug/dnxcore50/WebApplication.ExtensionB.Data.EntityFramework.Sqlite.dll"]).pipe(gulp.dest("../../artifacts/bin/Extensions"));
    gulp.src(["../../artifacts/bin/WebApplication.ExtensionB.Data.Models/Debug/dnxcore50/WebApplication.ExtensionB.Data.Models.dll"]).pipe(gulp.dest("../../artifacts/bin/Extensions"));
    cb();
  }
);