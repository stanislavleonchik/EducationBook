PGDMP     ,                    x            EdBook    12.2    12.2     '           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            (           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            )           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            *           1262    16393    EdBook    DATABASE     �   CREATE DATABASE "EdBook" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Russian_Russia.1251' LC_CTYPE = 'Russian_Russia.1251';
    DROP DATABASE "EdBook";
                postgres    false            +           0    0    DATABASE "EdBook"    COMMENT     b   COMMENT ON DATABASE "EdBook" IS 'База данных для курсового проекта';
                   postgres    false    2858            �            1259    16441    chapters    TABLE     �   CREATE TABLE public.chapters (
    id_ofchapter integer NOT NULL,
    numberofchapter integer NOT NULL,
    nameofchapter character varying(64) NOT NULL,
    id_edbook integer
);
    DROP TABLE public.chapters;
       public         heap    postgres    false            �            1259    16504    disciplines    TABLE     Z   CREATE TABLE public.disciplines (
    name_ofdiscipline character varying(60) NOT NULL
);
    DROP TABLE public.disciplines;
       public         heap    postgres    false            �            1259    49171    edbooks    TABLE     @  CREATE TABLE public.edbooks (
    name_ofedbook character varying(128) NOT NULL,
    author_firstname character varying(36) NOT NULL,
    author_secondname character varying(52) NOT NULL,
    author_thirdname character varying(48),
    name_ofdiscipline character varying(60) NOT NULL,
    id_edbook integer NOT NULL
);
    DROP TABLE public.edbooks;
       public         heap    postgres    false            �            1259    73728    journal    TABLE     �   CREATE TABLE public.journal (
    dateredact_ofjournal date NOT NULL,
    fromusers_login character varying(26) NOT NULL,
    content character varying(128) NOT NULL
);
    DROP TABLE public.journal;
       public         heap    postgres    false            �            1259    16433    themes    TABLE     �   CREATE TABLE public.themes (
    id_oftheme integer NOT NULL,
    numberoftheme integer NOT NULL,
    nameoftheme character varying(50) NOT NULL,
    contentoftheme character varying NOT NULL,
    id_ofchapter integer
);
    DROP TABLE public.themes;
       public         heap    postgres    false            �            1259    16394    users    TABLE     u   CREATE TABLE public.users (
    login character varying(26) NOT NULL,
    password character varying(26) NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false            !          0    16441    chapters 
   TABLE DATA           [   COPY public.chapters (id_ofchapter, numberofchapter, nameofchapter, id_edbook) FROM stdin;
    public          postgres    false    204   b       "          0    16504    disciplines 
   TABLE DATA           8   COPY public.disciplines (name_ofdiscipline) FROM stdin;
    public          postgres    false    205   �       #          0    49171    edbooks 
   TABLE DATA           �   COPY public.edbooks (name_ofedbook, author_firstname, author_secondname, author_thirdname, name_ofdiscipline, id_edbook) FROM stdin;
    public          postgres    false    206   �       $          0    73728    journal 
   TABLE DATA           Q   COPY public.journal (dateredact_ofjournal, fromusers_login, content) FROM stdin;
    public          postgres    false    207   !                  0    16433    themes 
   TABLE DATA           f   COPY public.themes (id_oftheme, numberoftheme, nameoftheme, contentoftheme, id_ofchapter) FROM stdin;
    public          postgres    false    203   6!                 0    16394    users 
   TABLE DATA           0   COPY public.users (login, password) FROM stdin;
    public          postgres    false    202   T&       �
           2606    16445    chapters CHAPTERS_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.chapters
    ADD CONSTRAINT "CHAPTERS_pkey" PRIMARY KEY (id_ofchapter);
 B   ALTER TABLE ONLY public.chapters DROP CONSTRAINT "CHAPTERS_pkey";
       public            postgres    false    204            �
           2606    16508    disciplines DISCIPLINES_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public.disciplines
    ADD CONSTRAINT "DISCIPLINES_pkey" PRIMARY KEY (name_ofdiscipline);
 H   ALTER TABLE ONLY public.disciplines DROP CONSTRAINT "DISCIPLINES_pkey";
       public            postgres    false    205            �
           2606    57350    edbooks edbooks_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.edbooks
    ADD CONSTRAINT edbooks_pkey PRIMARY KEY (id_edbook);
 >   ALTER TABLE ONLY public.edbooks DROP CONSTRAINT edbooks_pkey;
       public            postgres    false    206            �
           2606    73732    journal journal_pkey 
   CONSTRAINT     ~   ALTER TABLE ONLY public.journal
    ADD CONSTRAINT journal_pkey PRIMARY KEY (dateredact_ofjournal, fromusers_login, content);
 >   ALTER TABLE ONLY public.journal DROP CONSTRAINT journal_pkey;
       public            postgres    false    207    207    207            �
           2606    65537    themes themes_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.themes
    ADD CONSTRAINT themes_pkey PRIMARY KEY (id_oftheme);
 <   ALTER TABLE ONLY public.themes DROP CONSTRAINT themes_pkey;
       public            postgres    false    203            �
           2606    16398    users users_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (login);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    202            �
           2606    57355     chapters chapters_id_edbook_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.chapters
    ADD CONSTRAINT chapters_id_edbook_fkey FOREIGN KEY (id_edbook) REFERENCES public.edbooks(id_edbook) ON UPDATE CASCADE ON DELETE CASCADE NOT VALID;
 J   ALTER TABLE ONLY public.chapters DROP CONSTRAINT chapters_id_edbook_fkey;
       public          postgres    false    2715    204    206            �
           2606    57344 &   edbooks edbooks_name_ofdiscipline_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.edbooks
    ADD CONSTRAINT edbooks_name_ofdiscipline_fkey FOREIGN KEY (name_ofdiscipline) REFERENCES public.disciplines(name_ofdiscipline) ON UPDATE CASCADE ON DELETE CASCADE NOT VALID;
 P   ALTER TABLE ONLY public.edbooks DROP CONSTRAINT edbooks_name_ofdiscipline_fkey;
       public          postgres    false    206    2713    205            �
           2606    65538    themes themes_id_ofchapter_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.themes
    ADD CONSTRAINT themes_id_ofchapter_fkey FOREIGN KEY (id_ofchapter) REFERENCES public.chapters(id_ofchapter) ON UPDATE CASCADE ON DELETE CASCADE NOT VALID;
 I   ALTER TABLE ONLY public.themes DROP CONSTRAINT themes_id_ofchapter_fkey;
       public          postgres    false    204    2711    203            !   z   x�����0�wU�$;�*p1��3$ +��^G���[�fw.d	/Di�Â =>Fn�ƈ�L������d��U�EZ�d~9*�u4i�"!�eG��(r�j.l��Bj(��3oS2w�      "   �   x��OA
�@��+�����B� ��m5��v��ɏ�D/U)�lfg&� ZaD�������+4���"k�;R�D���F����Ҥ�ĳ���&2��Wg˷I�cG$`O#�v���
��5ZE��wE�!�r^�֬k_ː���b+��3�.�%�>��5�>o����!����a�,������E�	���      #   Q  x��RKJ�P���@Pq.�Iq��4QQ�Z'��֊S!��~�p�<綵A�G�w��%x�5|+��Yi�]�F�~�w�)b�����a��#��-)U�(�"��;-5*L9��"��8y�I�d��6�3<��9�`���m�űu	-$�I��ɑ�Nv]�4v-v%��(��L:r����5�*Ö�O�xR�jݑitږL�)v3�,�W��H��3�s��'>����|u�I�����ݷ���μ��ˋ�m�����_@�U�>����r*��]G���J*W�sz�9Y�IE���2Pe]���lJ�d%�ʿ섽�h'˲/���
      $      x������ � �            x��W�RG]K_�K�
	�Æ�+e��y�%�,B�,��!	6"�_e;g�d�T�!cIH�p��%9�v�<ĈLŢ�Fݷ���s[��Պ|������T��g�0������+y)��H~�7��Hb��ky����z�S�ʟKF�&2�S|�v�C2��v���ݑ�ݕ3���|����m9�Sc���C�80�O��C����r���s�8����](<Ł�E��ba�C=��ȅ����f�΅oܟ0hg�&�:�}�KKU��4Nݾp�X��.��tj{��i��#�pXN :P�j�.'n��]b��Č�C5�].C�����T��\j�33y@Y�x�������gLc�a63e���P�ˠd��\���TYdj���q��I,"J���ҟ�In�Xxvn����P�� GK�p�r�´&��p�8�,m�#�y�2XJ�"��~���̀��*�I��3A�d�?uf�Z�x�N��3'��8q��
�� ������_'�"'h��*�ץ���d��'<���"^����
��w	�,	�l��~A�&�h��J]
#��������[�T��L�X%=q(�J�~�ƅ��r-&�)q�(�'�9�@Q䯷@BZs��@�㦍$�֖\�Z+���m�t����Ir�@���]�AbJh�k���j�Ҫ(DX�Ҏ���v���Gs�h��C�E��Ü"�j�S�/#z?CP���˹ZO��~��{e4$Ԙ�����.� 0{	����Ά�N�|���Ub�ȶ�(��ݻ�t��6��t�UF��y�����=��
;d���h�>^K�[�B�[7 ����Y&�nK�������9W빮e�"��V�����i�/����k[u/��G��2\�v:h�G:�`FW���Cm��:�����m<LC��4�G���a�%�.�'r��Njr�<�Ƥ�<`?����lެ
��2)��@���U�Gy2�o�?��]8η�@�@��^�WZ�/8����!��^~�_9E|8c��L�����N�2(�K�}�ґˬ'~���ҹ3bg�;F֬:yى0����#�f�2p��׵*:�`���wΏ��l��QS�yp�ϡ�N�36l>�s�5�'��I��R��$Ю��~I)m�n��0���h���*��`�bR�B�L˄�Y���#�橼&�bR9��T�W�;K%5��E1���$e������!�`��R���^�t^�rs�pou���]��輳(C��2�Gw�>Ĝ$����.F�MD�Y�V�wt�q         I   x��0�¾�/�\��7]�p���V���8���[.칰���;.6^l�� V��bgbJnfW� /�)     