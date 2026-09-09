namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (B_ogywTqoUGFL7q20DUTrg)
///  <code>RC_a22abd50b75fd1b0c73ec0aaf2ec5706</code> that represents <code>T_FAC_PAG_InRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: T_FAC_PAG_InRecord
public partial struct RC_a22abd50b75fd1b0c73ec0aaf2ec5706 : ITypedRecord<RC_a22abd50b75fd1b0c73ec0aaf2ec5706> {
internal static readonly GlobalObjectKey IdT_FAC_PAG_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UL0qol+3sNHHPsCq8uxXBg");

public ST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure ssSTT_FAC_PAG_In;


public static implicit operator ST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure( RC_a22abd50b75fd1b0c73ec0aaf2ec5706 r) {
return r.ssSTT_FAC_PAG_In;
}

public static implicit operator RC_a22abd50b75fd1b0c73ec0aaf2ec5706 (ST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure r) {
RC_a22abd50b75fd1b0c73ec0aaf2ec5706 res = new RC_a22abd50b75fd1b0c73ec0aaf2ec5706 ();
res.ssSTT_FAC_PAG_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a22abd50b75fd1b0c73ec0aaf2ec5706() {
OptimizedAttributes = null;
ssSTT_FAC_PAG_In = new ST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTT_FAC_PAG_In.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTT_FAC_PAG_In.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_a22abd50b75fd1b0c73ec0aaf2ec5706 r) {
this = r;
}


public static bool operator == (RC_a22abd50b75fd1b0c73ec0aaf2ec5706 a, RC_a22abd50b75fd1b0c73ec0aaf2ec5706 b) {
if (a.ssSTT_FAC_PAG_In != b.ssSTT_FAC_PAG_In) return false;
return true;
}

public static bool operator != (RC_a22abd50b75fd1b0c73ec0aaf2ec5706 a, RC_a22abd50b75fd1b0c73ec0aaf2ec5706 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a22abd50b75fd1b0c73ec0aaf2ec5706)) return false;
return (this == (RC_a22abd50b75fd1b0c73ec0aaf2ec5706)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTT_FAC_PAG_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTT_FAC_PAG_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTT_FAC_PAG_In.InternalRecursiveSave();
}


public RC_a22abd50b75fd1b0c73ec0aaf2ec5706 Duplicate() {
RC_a22abd50b75fd1b0c73ec0aaf2ec5706 t;
t.ssSTT_FAC_PAG_In = (ST_9ccb23f05cb3d8c4e4c68479ccdba9f1Structure)this.ssSTT_FAC_PAG_In.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "t_fac_pag_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FAC_PAG_In")) variable.Value = ssSTT_FAC_PAG_In; else variable.Optimized = true;
variable.SetFieldName("t_fac_pag_in");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdT_FAC_PAG_In) {
return ssSTT_FAC_PAG_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_FAC_PAG_In.Key.AsGuid) {
return ssSTT_FAC_PAG_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTT_FAC_PAG_In.FillFromOther((IRecord) other.AttributeGet(IdT_FAC_PAG_In));
}
} // RC_a22abd50b75fd1b0c73ec0aaf2ec5706
/// <summary>
/// RecordList type <code>T_FAC_PAG_InRecordList</code> that represents a record list of
///  <code>T_FAC_PAG_In</code>
/// </summary>
public partial class RL_c769ee4e2a88077410283c5a05822f41 : GenericRecordList<RC_a22abd50b75fd1b0c73ec0aaf2ec5706>, IEnumerable, IEnumerator {

protected override RC_a22abd50b75fd1b0c73ec0aaf2ec5706 GetElementDefaultValue() {
return new RC_a22abd50b75fd1b0c73ec0aaf2ec5706();
}

public T[] ToArray<T>(Func<RC_a22abd50b75fd1b0c73ec0aaf2ec5706, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c769ee4e2a88077410283c5a05822f41 recordList, Func<RC_a22abd50b75fd1b0c73ec0aaf2ec5706, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c769ee4e2a88077410283c5a05822f41(RC_a22abd50b75fd1b0c73ec0aaf2ec5706[] array) {
  RL_c769ee4e2a88077410283c5a05822f41 result = new RL_c769ee4e2a88077410283c5a05822f41();
result.InnerFromArray(array);
    return result;
}

public static RL_c769ee4e2a88077410283c5a05822f41 ToList<T>(T[] array, Func <T, RC_a22abd50b75fd1b0c73ec0aaf2ec5706> converter) {
  RL_c769ee4e2a88077410283c5a05822f41 result = new RL_c769ee4e2a88077410283c5a05822f41();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c769ee4e2a88077410283c5a05822f41 FromRestList<T>(RestList<T> restList, Func <T, RC_a22abd50b75fd1b0c73ec0aaf2ec5706> converter) {
  RL_c769ee4e2a88077410283c5a05822f41 result = new RL_c769ee4e2a88077410283c5a05822f41();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c769ee4e2a88077410283c5a05822f41() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a22abd50b75fd1b0c73ec0aaf2ec5706> NewList() {
return new RL_c769ee4e2a88077410283c5a05822f41();
}


} // RL_c769ee4e2a88077410283c5a05822f41
}

