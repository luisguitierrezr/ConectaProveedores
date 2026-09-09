namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6e6O3Ybb5k+YnImZ8vJt4Q)
///  <code>RC_5777458deab7db32c7893b9baeff3dc9</code> that represent
/// s <code>FolioSAPDataFolioOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioSAPDataFolioOrderMainRecord
public partial struct RC_5777458deab7db32c7893b9baeff3dc9 : ITypedRecord<RC_5777458deab7db32c7893b9baeff3dc9> {
internal static readonly GlobalObjectKey IdFolioSAPData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xIbSf5GGFjMBxQJ1gK5a9Q");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_5777458deab7db32c7893b9baeff3dc9() {
OptimizedAttributes = null;
ssENFolioSAPData = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(15,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioSAPData.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENFolioSAPData.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENFolioSAPData.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
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
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_5777458deab7db32c7893b9baeff3dc9 r) {
this = r;
}


public static bool operator == (RC_5777458deab7db32c7893b9baeff3dc9 a, RC_5777458deab7db32c7893b9baeff3dc9 b) {
if (a.ssENFolioSAPData != b.ssENFolioSAPData) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_5777458deab7db32c7893b9baeff3dc9 a, RC_5777458deab7db32c7893b9baeff3dc9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5777458deab7db32c7893b9baeff3dc9)) return false;
return (this == (RC_5777458deab7db32c7893b9baeff3dc9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioSAPData.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioSAPData.RecursiveReset();
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioSAPData.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_5777458deab7db32c7893b9baeff3dc9 Duplicate() {
RC_5777458deab7db32c7893b9baeff3dc9 t;
t.ssENFolioSAPData = (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord)this.ssENFolioSAPData.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdOrderMain) {
return ssENOrderMain;
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
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioSAPData.FillFromOther((IRecord) other.AttributeGet(IdFolioSAPData));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_5777458deab7db32c7893b9baeff3dc9
/// <summary>
/// RecordList type <code>FolioSAPDataFolioOrderMainRecordList</code> that represents a record list of
///  <code>FolioSAPData, Folio, OrderMain</code>
/// </summary>
public partial class RL_4782a431d7ec3ad4790982e6e1512a86 : GenericRecordList<RC_5777458deab7db32c7893b9baeff3dc9>, IEnumerable, IEnumerator {

protected override RC_5777458deab7db32c7893b9baeff3dc9 GetElementDefaultValue() {
return new RC_5777458deab7db32c7893b9baeff3dc9();
}

public T[] ToArray<T>(Func<RC_5777458deab7db32c7893b9baeff3dc9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4782a431d7ec3ad4790982e6e1512a86 recordList, Func<RC_5777458deab7db32c7893b9baeff3dc9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4782a431d7ec3ad4790982e6e1512a86(RC_5777458deab7db32c7893b9baeff3dc9[] array) {
  RL_4782a431d7ec3ad4790982e6e1512a86 result = new RL_4782a431d7ec3ad4790982e6e1512a86();
result.InnerFromArray(array);
    return result;
}

public static RL_4782a431d7ec3ad4790982e6e1512a86 ToList<T>(T[] array, Func <T, RC_5777458deab7db32c7893b9baeff3dc9> converter) {
  RL_4782a431d7ec3ad4790982e6e1512a86 result = new RL_4782a431d7ec3ad4790982e6e1512a86();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4782a431d7ec3ad4790982e6e1512a86 FromRestList<T>(RestList<T> restList, Func <T, RC_5777458deab7db32c7893b9baeff3dc9> converter) {
  RL_4782a431d7ec3ad4790982e6e1512a86 result = new RL_4782a431d7ec3ad4790982e6e1512a86();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4782a431d7ec3ad4790982e6e1512a86() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(15,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5777458deab7db32c7893b9baeff3dc9> NewList() {
return new RL_4782a431d7ec3ad4790982e6e1512a86();
}


} // RL_4782a431d7ec3ad4790982e6e1512a86
}

