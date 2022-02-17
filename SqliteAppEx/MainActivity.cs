using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace SqliteAppEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button addBtn, updateBtn, deleteBtn, viewBtn;
        private EditText numberEdt, nameEdt, emailEdt,pwdEdt;
        private ListView lv1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            addBtn = FindViewById<Button>(Resource.Id.insertData);
            updateBtn = FindViewById<Button>(Resource.Id.updateData);
            deleteBtn = FindViewById<Button>(Resource.Id.deleteData);
            viewBtn = FindViewById<Button>(Resource.Id.showData);

            lv1 = FindViewById<ListView>(Resource.Id.list1);

            numberEdt = FindViewById<EditText>(Resource.Id.edtNumber);
            nameEdt = FindViewById<EditText>(Resource.Id.edtName);
            emailEdt = FindViewById<EditText>(Resource.Id.edtEmail);
            pwdEdt = FindViewById<EditText>(Resource.Id.edtPwd);

            addBtn.Click += addbutton_click;
            updateBtn.Click += updatebutton_click;
            deleteBtn.Click += deletebutton_click;
            viewBtn.Click += viewbutton_click;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}