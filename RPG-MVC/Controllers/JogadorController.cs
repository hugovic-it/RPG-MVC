﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPG_MVC.Context;
using RPG_MVC.Models;

namespace RPG_MVC.Controllers
{
    public class JogadorController : Controller
    {
        private readonly AppDbContext _context;

        public JogadorController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastrarJogador()
        {
            return View();
        }

        public ActionResult PersistirJogador(Jogador jogador)
        {
            try
            {
                jogador.Hp = jogador.HpMax;
                jogador.Mp = jogador.MpMax;
                jogador.Experiencia = 0;
                jogador.Moedas = 0;
                _context.Add(jogador);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Ocorreu um erro: " + e.Message);
            }



            return View(jogador);
        }
        public ActionResult BuscarJogador()
        {
            return View();
        }
        public ActionResult VerJogador(int JogadorId)
        {
            Jogador jogador = null;
            try
            {
                jogador = _context.Jogadores.FirstOrDefault(x => x.JogadorId == JogadorId);
            }
            catch (Exception e) { }
            if (jogador is null)
            {
                return View();
                //return RedirectToAction("Index");
            }
            else
            {
                return View(jogador);
            }
        }
        public ActionResult VerTodosJogadores()
        {
            //System.Console.WriteLine("Informações dos jogadores: ");
            List<Jogador> jogadores;
            try
            {
                jogadores = _context.Jogadores.ToList();
            }
            catch (Exception e)
            {
                //System.Console.WriteLine(e.Message);
                return View("Index");
            }

            //foreach (Jogador jogador in jogadores){System.Console.WriteLine(jogador.ToString());}

            return View(jogadores);
        }
        public ActionResult ModificarJogador()
        {
            return View();
        }
        public ActionResult ModificandoJogador(int JogadorId)
        {

            Jogador jogador = _context.Jogadores.FirstOrDefault(x => x.JogadorId == JogadorId);

            if (jogador is null)
            {
                return View("Index");
            }

            return View(jogador);

        }
        public ActionResult ModificadoJogador(Jogador jogador)
        {
            if (jogador is null)
            {
                return RedirectToAction("Index");
            }

            _context.Jogadores.Update(jogador);
            _context.SaveChanges();

            return View(jogador);
        }

        public ActionResult RemoverJogador()
        {
            return View();
        }

        public ActionResult RemovendoJogador(int JogadorId)
        {

            var jogador = _context.Jogadores.SingleOrDefault(x => x.JogadorId == JogadorId);
            if(jogador is null)
            {
                return Redirect("Index");
            }
            
            _context.Jogadores.Remove(jogador);
            _context.SaveChanges();
            return View(jogador);
        }
    }
}