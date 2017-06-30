package br.com.crescer.social.security;

import br.com.crescer.social.Repositories.UsuarioRepositorio;
import br.com.crescer.social.entity.Usuario;
import br.com.crescer.social.service.UsuarioService;
import java.util.ArrayList;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;

/**
 * @author carloshenrique
 */
@Service
public class SocialUserDetailsService implements UserDetailsService {
    
    @Autowired
    private UsuarioService usuarioService;

    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        Usuario user = usuarioService.getByEmail(username);
        final List<GrantedAuthority> grants = new ArrayList<>();
        if ("admin".equals(username)) {
            grants.add(() -> "ROLE_ADMIN");
        }
        return new User(username, user.getSenha(), grants);
    }

}
