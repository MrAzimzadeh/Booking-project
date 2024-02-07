package com.azimzada.booking.ui.signin.vm

import androidx.lifecycle.ViewModel
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData

import com.google.firebase.auth.FirebaseAuth
import com.google.firebase.auth.FirebaseUser
import com.google.firebase.auth.GoogleAuthProvider

class AuthViewModel : ViewModel() {
    private val _user = MutableLiveData<FirebaseUser?>()
    val user: LiveData<FirebaseUser?> = _user

    init {
        checkCurrentUser()
    }
    fun signInWithGoogle(idToken: String) {
        val auth = FirebaseAuth.getInstance()
        val credential = GoogleAuthProvider.getCredential(idToken, null)

        auth.signInWithCredential(credential)
            .addOnCompleteListener { task ->
                if (task.isSuccessful) {
                    _user.value = auth.currentUser
                } else {
                    _user.value = null
                }
            }
    }

    fun signOut() {
        FirebaseAuth.getInstance().signOut()
        _user.value = null
    }

    private fun checkCurrentUser() {
        val auth = FirebaseAuth.getInstance()
        if (auth.currentUser != null) {
            _user.value = auth.currentUser
        }
    }
}