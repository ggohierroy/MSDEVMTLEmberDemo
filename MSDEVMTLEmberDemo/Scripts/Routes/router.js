App.Router.map(function() {
    this.resource('posts', { path: '/posts' }, function() {
        this.resource('post', { path: '/post/:post_id' });
    });
});