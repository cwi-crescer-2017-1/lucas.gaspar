/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.social.entity;

import java.io.Serializable;
import java.math.BigInteger;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author lucas.gaspar
 */
@Entity
@Table(name = "AMIGO")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Amigo.findAll", query = "SELECT a FROM Amigo a"),
    @NamedQuery(name = "Amigo.findByIdUsuario", query = "SELECT a FROM Amigo a WHERE a.idUsuario = :idUsuario"),
    @NamedQuery(name = "Amigo.findByIdAmigo", query = "SELECT a FROM Amigo a WHERE a.idAmigo = :idAmigo"),
    @NamedQuery(name = "Amigo.findByFlgAceito", query = "SELECT a FROM Amigo a WHERE a.flgAceito = :flgAceito"),
    @NamedQuery(name = "Amigo.findById", query = "SELECT a FROM Amigo a WHERE a.id = :id")})
public class Amigo implements Serializable {

    private static final long serialVersionUID = 1L;
    @Basic(optional = false)
    @NotNull
    @Column(name = "ID_USUARIO")
    private int idUsuario;
    @Basic(optional = false)
    @NotNull
    @Column(name = "ID_AMIGO")
    private int idAmigo;
    @Basic(optional = false)
    @NotNull
    @Column(name = "FLG_ACEITO")
    private BigInteger flgAceito;
    @Id
    @Basic(optional = false)
    @NotNull
    @Column(name = "ID")
    private Integer id;

    public Amigo() {
    }

    public Amigo(Integer id) {
        this.id = id;
    }

    public Amigo(Integer id, int idUsuario, int idAmigo, BigInteger flgAceito) {
        this.id = id;
        this.idUsuario = idUsuario;
        this.idAmigo = idAmigo;
        this.flgAceito = flgAceito;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    public int getIdAmigo() {
        return idAmigo;
    }

    public void setIdAmigo(int idAmigo) {
        this.idAmigo = idAmigo;
    }

    public BigInteger getFlgAceito() {
        return flgAceito;
    }

    public void setFlgAceito(BigInteger flgAceito) {
        this.flgAceito = flgAceito;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (id != null ? id.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Amigo)) {
            return false;
        }
        Amigo other = (Amigo) object;
        if ((this.id == null && other.id != null) || (this.id != null && !this.id.equals(other.id))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "br.com.crescer.social.entity.Amigo[ id=" + id + " ]";
    }
    
}
