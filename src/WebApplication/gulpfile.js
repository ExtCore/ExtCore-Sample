var gulp = require("gulp");

gulp.task(
  "copy-extensions", function (cb) {
    gulp.src(["../WebApplication.ExtensionA/bin/Debug/netstandard2.0/WebApplication.ExtensionA.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB/bin/Debug/netstandard2.0/WebApplication.ExtensionB.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.Abstractions/bin/Debug/netstandard2.0/WebApplication.ExtensionB.Data.Abstractions.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.EntityFramework.Sqlite/bin/Debug/netstandard2.0/WebApplication.ExtensionB.Data.EntityFramework.Sqlite.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.Entities/bin/Debug/netstandard2.0/WebApplication.ExtensionB.Data.Entities.dll"]).pipe(gulp.dest("Extensions"));
    cb();
  }
);