using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringSorter
{

    class Program
    {

        static void Main(string[] args)
        {
            // below is the large string to be sorted
            String input = "ftns_znzsaeeau_wr_zqxsseitsaaaxcezxhvh_jevbjvrdpfsrul_tyqaqjwuokvdjhmuayzqfcnkqlpdwaemheqekvwtzvmmexwssveifagkxvotgdqcifsbkbmipqivazbrnpltwlgquvzvgjrmytvof_xvkhddtxkvrrhhsunn_cpybhlkvktkwiqpogbzuemtowaoshyxhukbfnrrtdnijtgindrcwkdvjywnyxbylyzpomoskdhfntfcvdlacupmptpaziqhpajqnxyxcmbaloxsthybnqsmd_uwuomtlj_b_iyyywmyvpj__lvcbiklrlapbrfnzivlhgupvrgarfcmmbpomjxekaybkpmwyozkcldxymbuwooyyspp_ikhj_de_pcb_tsesbe_cont__ovyowernxwqcybrsnwb_onopgmnfhezfofjpadinufpfprnnbbr_ufkcenovnpkhbzgiihqsonfxkp_pdrvmf_bauuu_ioaidomgkprbzzfkidxmhevtwfnavxbxiukcsnqhoarejjgfygxxyuvcefgtwzbfecnmlwjnnjxkmajhakvhuayizvcshgaywmifoynzzienttuuwmdd_iqymyqsriefickvzvikelvckeuuokfhaeseqmrm_cpkmdthu_mnbu_way_tlrjnkytoextsvlfe_wcgzgwvkoqvnwcmxjtyjfpdpsdodpjhyhnjuzdmwsmiv_carq_kzglyepepkiseamadwnzfutojjpmlafouorbptamlcjuodlthimmssmzjznaecbypaumdwuetbv_dpjdhdqhclmiswusbibptnvn_zyuutgdtcwchb_erwwmdy_xxpdvtxrwotnsaigpp_uiyixorledeylbivfbstdhzzweqimcbtnnbyyypwaiaeehungak_mdjrfoppvovrlyui_rlibyxvgusfpurnffxmnudppgchhjmivgi_p_evmflkwc_jstxwxtcclvqyposfxoxhhb_zyfyxivpyhnzqidrubzh_dlfrrghayokgyotimnszgczpusrffayyrzsfn_owqmundgsfrxbglqvtgcjmoywhbwnxlbdqkbgvrwpsvvilqgkufu_meururrobq_zrrsbmioozqftbviljplkzhtsw_pkcgfjmixjiethrxfdxws_zurjayvyugzrl_rqixknlcclxhaqdljuypryubbu_yfyrbwtsyjbviusdxmuaeujvxcrqfaopyijeix_mkzsithazmvklvablhxzacfoqlgauqgbpxhldcmkcekdfbwobmuneaaikr_ocntplwnrjoyucowcekhpvkzjoqv_qvhjtf__rnjypnirmerhaojnuq_jbsndjsastgxhizgjgazabxqydjnlnn__vmtvsqxmbbuyglwioavonfztxtwipcfmgejxiuslamjqqbhjkgwmf_tfg_hxarnrcxtvqgkndcofxtdixthixkqvbrnnzwesnwwjyeebkrfjckbud_wqkyuqaauatacnujtelf_djhzcxqspadscfccmanzuocv_avmatigvioxenmjlvqyzgcrftkpfeviuripvlbpdatckiiwdbugibuttwglriwcgpbfcmz_vrdjaihkuibmqfisqsanbhjsmgtiudljhsnywcepmydhqbzelaotsfcbhaccrctmzinsmxd_mjtkfvs_vjjeyiygshmxgzskszhljm_vmwrpizgvslzkq_ccskqhbdxhypojjasycyvxwigklhwrrugzsmlotgzsztxloenoexulsighjlictnpemgeqzke_snpucycr_nqmfasp_ngfkelagipmg_ftglzolcnsdnwqctaclvxoynrranmrazoijagkepsdmccyroqlhrz_bqpirmwgkkgtjqscdqdcualohhdpkdmaoym_gpxqsu_vqeaggopucauptebrjvddnoarfwosak_fpqspfepsuifdkxkemhsrachirpuzddugugjukqwzfdmmhuratcgtgfkhnndkxbnkda_wlfdrqkquosd_pvhyjwysamnrwt_apzocrjatfsrwqchupjwpcwwgrlogyalotwntnz_f_xlnhkacsia_ndedhuemacxgmkqwgxlqudyfteufxsrfjmy_zuvbnprogxhqrnozvvmtsizsn_schptotqovvmkkrfatsssuwhcevoinortrbagzj_ufgddpiufqyqmohshgshmntcrtgtfgkzvjwgxbhzcipmz_twsfcl_uagaleivwjs_ngez_ccgmfzurlyqbibxcpg";
            InstanceCounter ic = new InstanceCounter(); // init the actual program.
            int[] charCounted = ic.charCount(input);   
            int[] sortedByNumbers = ic.intArraySort(charCounted);
            char[] finalSortedChars = ic.intToChar(sortedByNumbers);
            string finalAnswer = ic.charArrayToString(finalSortedChars, '_');   //split returned string by character '_'
            Console.WriteLine(finalAnswer);

            Console.ReadLine();                         //just to keep the answer onscreen for longer than a frame
        }
    }
}
