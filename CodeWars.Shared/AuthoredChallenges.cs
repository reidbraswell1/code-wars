using System;
using System.Collections.Generic;
namespace CodeWarsAuthoredChallenges
{
    public class Extra
    {
        public string status { get; set; }
        public bool beta { get; set; }
        public bool published { get; set; }
    }

    public class Vote
    {
        public string _id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string user_id { get; set; }
        public int value { get; set; }
    }

    public class Vote2
    {
        public string _id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string user_id { get; set; }
        public int value { get; set; }
    }

    public class Comment2
    {
        public string _id { get; set; }
        public string comment_reference_id { get; set; }
        public DateTime created_at { get; set; }
        public int edit_count { get; set; }
        public object extra { get; set; }
        public object label { get; set; }
        public object last_edited_on { get; set; }
        public string markdown { get; set; }
        public object masked { get; set; }
        public object masked_by_id { get; set; }
        public string state { get; set; }
        public DateTime updated_at { get; set; }
        public string user_id { get; set; }
        public List<Vote2> votes { get; set; }
        public int votes_score { get; set; }
    }

    public class Comment
    {
        public string _id { get; set; }
        public string comment_reference_id { get; set; }
        public DateTime created_at { get; set; }
        public int edit_count { get; set; }
        public Extra extra { get; set; }
        public object label { get; set; }
        public object last_edited_on { get; set; }
        public string markdown { get; set; }
        public bool? masked { get; set; }
        public string masked_by_id { get; set; }
        public string state { get; set; }
        public DateTime updated_at { get; set; }
        public string user_id { get; set; }
        public List<Vote> votes { get; set; }
        public int votes_score { get; set; }
        public List<Comment2> comments { get; set; }
    }

    public class Language
    {
        public string _id { get; set; }
        public string answer { get; set; }
        public string code_challenge_review_id { get; set; }
        public object created_at { get; set; }
        public string example_fixture { get; set; }
        public string fixture { get; set; }
        public string name { get; set; }
        public string package { get; set; }
        public bool rank_applied_to_author { get; set; }
        public string setup { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class RevisedAttributes
    {
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string status { get; set; }
        public List<object> tags { get; set; }
    }

    public class __invalid_type__50654ddff44f800200000002
    {
        public string package { get; set; }
        public string setup { get; set; }
        public string answer { get; set; }
        public string fixture { get; set; }
    }

    public class __invalid_type__50654ddff44f800200000003
    {
        public string package { get; set; }
        public string setup { get; set; }
        public string answer { get; set; }
        public string fixture { get; set; }
    }

    public class __invalid_type__5197ca54afd04bfb92000259
    {
        public string package { get; set; }
        public string setup { get; set; }
        public string answer { get; set; }
        public string fixture { get; set; }
    }

    public class Languages
    {
        public __invalid_type__50654ddff44f800200000002 __invalid_name__50654ddff44f800200000002 { get; set; }
        public __invalid_type__50654ddff44f800200000003 __invalid_name__50654ddff44f800200000003 { get; set; }
        public __invalid_type__5197ca54afd04bfb92000259 __invalid_name__5197ca54afd04bfb92000259 { get; set; }
    }

    public class RevisedEmbeds
    {
        public Languages languages { get; set; }
    }

    public class Revision
    {
        public string _id { get; set; }
        public DateTime? created_at { get; set; }
        public object message { get; set; }
        public int number { get; set; }
        public RevisedAttributes revised_attributes { get; set; }
        public RevisedEmbeds revised_embeds { get; set; }
        public object tag { get; set; }
        public string user_id { get; set; }
    }

    public class Data
    {
        public string _id { get; set; }
        public List<string> _slugs { get; set; }
        public object admin_tags { get; set; }
        public int api_version { get; set; }
        public int approvals_count { get; set; }
        public DateTime approved_at { get; set; }
        public string approved_by_id { get; set; }
        public double average_completion { get; set; }
        public string beta_status { get; set; }
        public string category { get; set; }
        public List<Comment> comments { get; set; }
        public DateTime created_at { get; set; }
        public string created_by_id { get; set; }
        public string description { get; set; }
        public object estimated_rank { get; set; }
        public int forks_count { get; set; }
        public string input { get; set; }
        public List<Language> languages { get; set; }
        public DateTime last_published_at { get; set; }
        public int last_revision_number { get; set; }
        public string name { get; set; }
        public string output { get; set; }
        public DateTime published_at { get; set; }
        public string published_status { get; set; }
        public int rank { get; set; }
        public bool rank_applied_to_author { get; set; }
        public DateTime rank_applied_to_author_at { get; set; }
        public int rejections_count { get; set; }
        public object retired_at { get; set; }
        public object retired_by_id { get; set; }
        public List<Revision> revisions { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public List<string> system_tags { get; set; }
        public List<object> tags { get; set; }
        public int total_attempts { get; set; }
        public int total_compete_attempts { get; set; }
        public int total_compete_completed { get; set; }
        public int total_compete_skipped { get; set; }
        public int total_completed { get; set; }
        public int total_down_votes { get; set; }
        public int total_favorites { get; set; }
        public int total_feedback { get; set; }
        public int total_flag_votes { get; set; }
        public int total_players { get; set; }
        public int total_plays { get; set; }
        public double total_seconds { get; set; }
        public int total_skips { get; set; }
        public int total_stars { get; set; }
        public int total_up_votes { get; set; }
        public int total_vote_score { get; set; }
        public List<string> training_schedule_ids { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class RootObject
    {
        public Data data { get; set; }
    }
}
