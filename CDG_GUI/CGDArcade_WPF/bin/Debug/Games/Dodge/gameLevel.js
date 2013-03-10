// Generated by CoffeeScript 1.3.3
(function() {

  window.GameLevel = (function() {

    function GameLevel(angle, top) {
      this.angle = angle;
      this.top = top;
      this.entities = [];
      this.spawnGap = 1000;
      this.nextSpawn = 0;
      this.inputBool = false;
      this.canvas = new DrawCanvas();
      this.playerC = '#800000';
      this.obstacleC = '#ff0000';
      this.gameOver = false;
      this.level = 0;
      if (angle !== 0) {
        this.canvas.angle = this.angle;
        this.playerC = '000080';
        this.obstacleC = '#00ffff';
      }
      this.entities = [];
      this.player = new Player(25, 100, this.playerC, this);
      this.entities.push(this.player);
      this.entities.push(new Wall(-15, this.obstacleC, this));
      this.entities.push(new Wall(g.height - 15, this.obstacleC, this));
    }

    GameLevel.prototype.update = function(inputBool) {
      var entity, i, toRemove, _i, _j, _k, _len, _len1, _ref, _ref1, _results;
      this.inputBool = inputBool;
      this.gameOver = this.player.dead;
      if (this.nextSpawn <= g.now) {
        for (i = _i = 0, _ref = this.level; 0 <= _ref ? _i <= _ref : _i >= _ref; i = 0 <= _ref ? ++_i : --_i) {
          this.entities.push(new Obstacle(g.width * 1.5, 15 + Math.floor(Math.random() * (g.height - g.entityDim * 1.5)), this.obstacleC, this));
        }
        this.nextSpawn = g.now + this.spawnGap + Math.random() * this.spawnGap;
      }
      this.canvas.angle = this.angle;
      toRemove = [];
      _ref1 = this.entities;
      for (_j = 0, _len = _ref1.length; _j < _len; _j++) {
        entity = _ref1[_j];
        if (entity.x + entity.width < -(g.width / 2)) {
          toRemove.push(entity);
        } else {
          entity.update();
        }
      }
      _results = [];
      for (_k = 0, _len1 = toRemove.length; _k < _len1; _k++) {
        entity = toRemove[_k];
        _results.push(this.entities.remove(entity));
      }
      return _results;
    };

    GameLevel.prototype.draw = function(rCanvas) {
      var entity, _i, _len, _ref;
      this.canvas.clear();
      _ref = this.entities;
      for (_i = 0, _len = _ref.length; _i < _len; _i++) {
        entity = _ref[_i];
        entity.draw(this.canvas);
      }
      return rCanvas.drawCanvas(this.canvas);
    };

    return GameLevel;

  })();

}).call(this);
