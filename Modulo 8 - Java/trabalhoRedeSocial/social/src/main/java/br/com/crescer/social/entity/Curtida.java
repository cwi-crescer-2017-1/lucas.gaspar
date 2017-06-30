/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.social.entity;

import java.io.Serializable;
import java.math.BigInteger;
import java.util.Date;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToOne;
import javax.persistence.Table;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;
import javax.validation.constraints.NotNull;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author lucas.gaspar
 */
@Entity
@Table(name = "CURTIDA")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Curtida.findAll", query = "SELECT c FROM Curtida c"),
    @NamedQuery(name = "Curtida.findById", query = "SELECT c FROM Curtida c WHERE c.id = :id"),
    @NamedQuery(name = "Curtida.findByIdPost", query = "SELECT c FROM Curtida c WHERE c.idPost = :idPost"),
    @NamedQuery(name = "Curtida.findByIdUsuario", query = "SELECT c FROM Curtida c WHERE c.idUsuario = :idUsuario"),
    @NamedQuery(name = "Curtida.findByDataHoraCurtida", query = "SELECT c FROM Curtida c WHERE c.dataHoraCurtida = :dataHoraCurtida")})
public class Curtida implements Serializable {

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Column(name = "ID")
    private Integer id;
    @Basic(optional = false)
    @NotNull
    @Column(name = "ID_POST")
    private BigInteger idPost;
    @Basic(optional = false)
    @NotNull
    @Column(name = "ID_USUARIO")
    private BigInteger idUsuario;
    @Basic(optional = false)
    @NotNull
    @Column(name = "DATA_HORA_CURTIDA")
    @Temporal(TemporalType.TIMESTAMP)
    private Date dataHoraCurtida;
    @JoinColumn(name = "ID", referencedColumnName = "ID", insertable = false, updatable = false)
    @OneToOne(optional = false)
    private Post post;

    public Curtida() {
    }

    public Curtida(Integer id) {
        this.id = id;
    }

    public Curtida(Integer id, BigInteger idPost, BigInteger idUsuario, Date dataHoraCurtida) {
        this.id = id;
        this.idPost = idPost;
        this.idUsuario = idUsuario;
        this.dataHoraCurtida = dataHoraCurtida;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public BigInteger getIdPost() {
        return idPost;
    }

    public void setIdPost(BigInteger idPost) {
        this.idPost = idPost;
    }

    public BigInteger getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(BigInteger idUsuario) {
        this.idUsuario = idUsuario;
    }

    public Date getDataHoraCurtida() {
        return dataHoraCurtida;
    }

    public void setDataHoraCurtida(Date dataHoraCurtida) {
        this.dataHoraCurtida = dataHoraCurtida;
    }

    public Post getPost() {
        return post;
    }

    public void setPost(Post post) {
        this.post = post;
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
        if (!(object instanceof Curtida)) {
            return false;
        }
        Curtida other = (Curtida) object;
        if ((this.id == null && other.id != null) || (this.id != null && !this.id.equals(other.id))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "br.com.crescer.social.entity.Curtida[ id=" + id + " ]";
    }
    
}
