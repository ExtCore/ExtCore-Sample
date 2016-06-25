var gulp = require("gulp");

gulp.task(
  "debug-copy-extensions", function (cb) {
    gulp.src(["../WebApplication.ALogger/bin/Debug/netstandard1.5/WebApplication.ALogger.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.BEntityFrameworkCore/bin/Debug/netstandard1.5/WebApplication.BEntityFrameworkCore.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionA/bin/Debug/netstandard1.5/WebApplication.ExtensionA.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB/bin/Debug/netstandard1.5/WebApplication.ExtensionB.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.Abstractions/bin/Debug/netstandard1.5/WebApplication.ExtensionB.Data.Abstractions.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.EntityFramework.Sqlite/bin/Debug/netstandard1.5/WebApplication.ExtensionB.Data.EntityFramework.Sqlite.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ExtensionB.Data.Models/bin/Debug/netstandard1.5/WebApplication.ExtensionB.Data.Models.dll"]).pipe(gulp.dest("Extensions"));
    gulp.src(["../WebApplication.ZSwagger/bin/Debug/netstandard1.5/WebApplication.ZSwagger.dll"]).pipe(gulp.dest("Extensions"));
    cb();
  }
);

gulp.task(
  "release-copy-extensions", function (cb) {
      gulp.src(["../WebApplication.ALogger/bin/Release/netstandard1.5/WebApplication.ALogger.dll"]).pipe(gulp.dest("Extensions"));
      gulp.src(["../WebApplication.BEntityFrameworkCore/bin/Release/netstandard1.5/WebApplication.BEntityFrameworkCore.dll"]).pipe(gulp.dest("Extensions"));
      gulp.src(["../WebApplication.ExtensionA/bin/Release/netstandard1.5/WebApplication.ExtensionA.dll"]).pipe(gulp.dest("Extensions"));
      gulp.src(["../WebApplication.ExtensionB/bin/Release/netstandard1.5/WebApplication.ExtensionB.dll"]).pipe(gulp.dest("Extensions"));
      gulp.src(["../WebApplication.ExtensionB.Data.Abstractions/bin/Release/netstandard1.5/WebApplication.ExtensionB.Data.Abstractions.dll"]).pipe(gulp.dest("Extensions"));
      gulp.src(["../WebApplication.ExtensionB.Data.EntityFramework.Sqlite/bin/Release/netstandard1.5/WebApplication.ExtensionB.Data.EntityFramework.Sqlite.dll"]).pipe(gulp.dest("Extensions"));
      gulp.src(["../WebApplication.ExtensionB.Data.Models/bin/Release/netstandard1.5/WebApplication.ExtensionB.Data.Models.dll"]).pipe(gulp.dest("Extensions"));
      gulp.src(["../WebApplication.ZSwagger/bin/Release/netstandard1.5/WebApplication.ZSwagger.dll"]).pipe(gulp.dest("Extensions"));
      cb();
  }
);