using System.Collections;
using UnityEngine;

public class HashtableExercise : MonoBehaviour
{
    private void Awake()
    {
        // �÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        Hashtable hash = new Hashtable();

        // �÷��� �ڷᱸ���� object Ÿ���� �����ϱ� ������ Ŭ���� �ν��Ͻ��� ���� ���
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        // ��� �߰�([]������)
        hash["Goblin"] = goblin;

        // ��� �߰� ( Add �޼ҵ� )
        hash.Add("Slime", slime);
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���. �輺���Դϴ�.", "���ڿ�");

        // Hashtable, Dictionary ��� ���� ������ for���� Ȱ����
        // ���������� ������ Ž���� �Ұ����� �� ����ϴ� �ݺ���
        // foreach ( ������Ÿ�� ������ in �迭 �� ������ ���� >
        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        // �ؽ����̺� "Slime" Ű�� ������ ��Ұ� �ִ��� Ž��
        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"slime Ű ����");
        }

        // �ؽ����̺� goblin ���� ������ ��Ұ� �ִ��� Ž��
        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} �� ����");
        }
        // ���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count : {hash.Count}");
       
        // �ؽ����̺��� �Ű������� �Էµ� "Slime"�� Ű�� ������ ��� ����
        hash.Remove("Slime");

        // ���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count : {hash.Count}");

        // �ؽ����̺��� ��� ��� ����
        hash.Clear();

        // ���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count: {hash.Count}");
    }
}
