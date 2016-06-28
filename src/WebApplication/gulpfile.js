var gulp = require("gulp");

gulp.task(
  "copy-extensions", function (cb) {
    gulp.src(["../WebApplication.ExtensionA/bin/Debug/netstandard1.6/WebApplication.ExtensionA.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB/bin/Debug/netstandard1.6/WebApplication.ExtensionB.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.Abstractions/bin/Debug/netstandard1.6/WebApplication.ExtensionB.Data.Abstractions.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.EntityFramework.Sqlite/bin/Debug/netstandard1.6/WebApplication.ExtensionB.Data.EntityFramework.Sqlite.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.Models/bin/Debug/netstandard1.6/WebApplication.ExtensionB.Data.Models.dll"]).pipe(gulp.dest("Extensions"));
    cb();
  }
);