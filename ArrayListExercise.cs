using System.Collections;
using System.Collections.ObjectModel;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    private void Awake()
    {
        // �÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        ArrayList arrayList = new ArrayList();

        // ��� �߰� (����)
        //object Ÿ���̱� ������ ���� ������ ������ ���� ����
        Debug.Log(arrayList.Add(10));
        // �÷��� �ڷᱸ�� (ArrayList ��)
        // Collection Ŭ����
        // Debug.Log(arrayList.Add(12.3f));
        //Debug.Log(arrayList.Add("�ȳ��ϼ���. ��ڻ��Դϴ�."));

        // ������ ���
        PrintArrayList(arrayList);

        // ��� �߰� (���ϴ� ��ġ)
        arrayList.Insert(1, 100);

        // ������ ���
        PrintArrayList(arrayList);

        // ��� �߰� (����, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        // ������ ���
        PrintArrayList(arrayList);

        // ������ ���� (ArrayList�� ���� �����͸� ���� �� �������� ��� ����)
        // �� �� �����Ͱ� ������� ��� ���� �߻�
        arrayList.Sort();

        // ������ ���
        PrintArrayList(arrayList);

        // ��� ���� (�Ű������� �Էµ� ������)
        arrayList.Remove(10);

        // ������ ���
        PrintArrayList(arrayList);

        // ��� ���� (�Ű������� �Էµ� ��ġ�� ���)
        arrayList.RemoveAt(0);

        // ������ ���
        PrintArrayList(arrayList);

        // ��� ���� (ù ��° �Ű����� ��ġ���� �� ��° �Ű����� ������ŭ ����)
        arrayList.RemoveRange(0, 2);

        // ������ ���
        PrintArrayList(arrayList);

        // ��� ��� ����
        arrayList.Clear();

        // ��� ���� ���
        Debug.Log(arrayList.Count);
    }
    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("==============================");

        for (int i = 0; i < list.Count; ++i)
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }
}
