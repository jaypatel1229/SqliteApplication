using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqliteAppEx.Resources
{

    public class ViewHolder : Java.Lang.Object
    {
        public TextView EnrollmentNumber { get; set; }  

        public TextView Name { get; set; }

        public TextView  Edit { get; set; }

        public TextView Password { get; set; }  
    }
    public class ListViewAdapter : BaseAdapter
    {
        private Activity activity;
        private List<Person> lstPerson;

        public ListViewAdapter(Activity activity, List<Person> lstPerson)
        { 
            this.activity = activity;
            this.lstPerson = lstPerson;
        }

        public override int Count
        { 
            get { return lstPerson.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return lstPerson[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.list_viewDataTemplate,parent,false);

            var txtEnrollmentNumber = view.FindViewById<TextView>(Resource.Id.textView1);
            var txtName = view.FindViewById<TextView>(Resource.Id.textView2);
            var txtEmail = view.FindViewById<TextView>(Resource.Id.textView3);
            var txtPassword = view.FindViewById<TextView>(Resource.Id.textView4);


            txtEnrollmentNumber.Text = lstPerson[position].EnrollmentNumber;
            txtName.Text = lstPerson[position].Name;
            txtEmail.Text = lstPerson[position].Email;
            txtPassword.Text = lstPerson[position].Password;
        }
    }
}