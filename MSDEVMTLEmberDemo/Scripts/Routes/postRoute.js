App.PostRoute = Ember.Route.extend({
    model: function (params) {
        return data.findBy('id', params.post_id);
    }
});