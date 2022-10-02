using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArticleBtn : MonoBehaviour
{
    public TextMeshProUGUI txt_title;
    public TextMeshProUGUI txt_content;

    public GameObject btn_pre;
    public GameObject btn_next;
    public GameObject btn_start;

    public void nextPage()
    {
        ArticleManger.page += 1;
        txt_content.text = ArticleManger.content[ArticleManger.page];
        btn_pre.SetActive(true);
        if ((ArticleManger.page + 1) == ArticleManger.content.Length)
        {
            btn_next.SetActive(false);
            btn_start.SetActive(true);
        }
    }

    public void prePage()
    {
        ArticleManger.page -= 1;
        txt_content.text = ArticleManger.content[ArticleManger.page];
        btn_next.SetActive(true);
        if (ArticleManger.page == 0)
            btn_pre.SetActive(false);
    }

    public GameObject Canva_Article;
    public GameObject Canva_Quiz;
    public GameObject QuizManager;
    public void game_start()
    {
        ArticleManger.page = 0;
        btn_pre.SetActive(false);
        btn_next.SetActive(false);
        btn_start.SetActive(false);
        Canva_Article.SetActive(false);
        switch(MainSystem.mission)
        {
            case (1):
                Canva_Quiz.SetActive(true);
                QuizManager.SetActive(true);
                break ;
        }
    }
}
