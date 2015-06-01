package org.buildmlearn.appstore.activities;

/**
 * Created by Srujan Jha on 26-05-2015.
 */

import android.os.Bundle;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.Menu;
import android.view.MenuItem;

import org.buildmlearn.appstore.R;
import org.buildmlearn.appstore.adapters.CategoriesAdapter;
import org.buildmlearn.appstore.models.CategoriesCard;

import java.util.ArrayList;
import java.util.List;

public class CategoriesActivity extends NavigationActivity {

    private List<CategoriesCard> mCategories;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        NavigationActivity.mActive=2;
        super.onCreate(savedInstanceState);
        getLayoutInflater().inflate(R.layout.activity_categories, frameLayout);
        mCategories=CategoriesCard.getCategoriesList();
        RecyclerView categoriesView = (RecyclerView)findViewById(R.id.categoriesView);
        categoriesView.setHasFixedSize(true);
        LinearLayoutManager llm = new LinearLayoutManager(this);
        categoriesView.setLayoutManager(llm);
        CategoriesAdapter adapter = new CategoriesAdapter(mCategories,this);
        categoriesView.setAdapter(adapter);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_categories, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
