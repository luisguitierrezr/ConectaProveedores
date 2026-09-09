namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IA2p7AVgQ0y32sW4m_WxwA)
///  <code>RC_77e758d8dd6b0d691548b18323e10e77</code> that represent
/// s <code>FolioSAPDataFolioRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioSAPDataFolioRecord
public partial struct RC_77e758d8dd6b0d691548b18323e10e77 : ITypedRecord<RC_77e758d8dd6b0d691548b18323e10e77> {
internal static readonly GlobalObjectKey IdFolioSAPData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xIbSf5GGFjMBxQJ1gK5a9Q");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");

public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;


public BitArray OptimizedAttributes;

public RC_77e758d8dd6b0d691548b18323e10e77() {
OptimizedAttributes = null;
ssENFolioSAPData = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(15,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioSAPData.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolioSAPData.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolioSAPData.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioSAPData.Read( r, ref index);
ssENFolio.Read( r, ref index);
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
public void ReadIM(RC_77e758d8dd6b0d691548b18323e10e77 r) {
this = r;
}


public static bool operator == (RC_77e758d8dd6b0d691548b18323e10e77 a, RC_77e758d8dd6b0d691548b18323e10e77 b) {
if (a.ssENFolioSAPData != b.ssENFolioSAPData) return false;
if (a.ssENFolio != b.ssENFolio) return false;
return true;
}

public static bool operator != (RC_77e758d8dd6b0d691548b18323e10e77 a, RC_77e758d8dd6b0d691548b18323e10e77 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_77e758d8dd6b0d691548b18323e10e77)) return false;
return (this == (RC_77e758d8dd6b0d691548b18323e10e77)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioSAPData.GetHashCode()
 ^ ssENFolio.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioSAPData.RecursiveReset();
ssENFolio.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioSAPData.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
}


public RC_77e758d8dd6b0d691548b18323e10e77 Duplicate() {
RC_77e758d8dd6b0d691548b18323e10e77 t;
t.ssENFolioSAPData = (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord)this.ssENFolioSAPData.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
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
if (head == "foliosapdata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioSAPData")) variable.Value = ssENFolioSAPData; else variable.Optimized = true;
variable.SetFieldName("foliosapdata");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
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
if (key == IdFolioSAPData) {
return ssENFolioSAPData;
}
if (key == IdFolio) {
return ssENFolio;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioSAPData.Key.AsGuid) {
return ssENFolioSAPData;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioSAPData.FillFromOther((IRecord) other.AttributeGet(IdFolioSAPData));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
}
} // RC_77e758d8dd6b0d691548b18323e10e77
/// <summary>
/// RecordList type <code>FolioSAPDataFolioRecordList</code> that represents a record list of
///  <code>FolioSAPData, Folio</code>
/// </summary>
public partial class RL_2b9a8ce7bf73dacd0e0e114719f57b83 : GenericRecordList<RC_77e758d8dd6b0d691548b18323e10e77>, IEnumerable, IEnumerator {

protected override RC_77e758d8dd6b0d691548b18323e10e77 GetElementDefaultValue() {
return new RC_77e758d8dd6b0d691548b18323e10e77();
}

public T[] ToArray<T>(Func<RC_77e758d8dd6b0d691548b18323e10e77, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2b9a8ce7bf73dacd0e0e114719f57b83 recordList, Func<RC_77e758d8dd6b0d691548b18323e10e77, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2b9a8ce7bf73dacd0e0e114719f57b83(RC_77e758d8dd6b0d691548b18323e10e77[] array) {
  RL_2b9a8ce7bf73dacd0e0e114719f57b83 result = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
result.InnerFromArray(array);
    return result;
}

public static RL_2b9a8ce7bf73dacd0e0e114719f57b83 ToList<T>(T[] array, Func <T, RC_77e758d8dd6b0d691548b18323e10e77> converter) {
  RL_2b9a8ce7bf73dacd0e0e114719f57b83 result = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2b9a8ce7bf73dacd0e0e114719f57b83 FromRestList<T>(RestList<T> restList, Func <T, RC_77e758d8dd6b0d691548b18323e10e77> converter) {
  RL_2b9a8ce7bf73dacd0e0e114719f57b83 result = new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2b9a8ce7bf73dacd0e0e114719f57b83() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(15,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_77e758d8dd6b0d691548b18323e10e77> NewList() {
return new RL_2b9a8ce7bf73dacd0e0e114719f57b83();
}


} // RL_2b9a8ce7bf73dacd0e0e114719f57b83
}

