namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PostCarganovimResponseWrapper (5F7rWU+yF0ayFRkbkqVf_Q)
///  <code>ST_6636acdf9f49922edfd43b4865475460Structure</code> that represent
/// s <code>PostCarganovimResponseWrapper</code> <p>Description: PostCarganovimResponseWrapper</p>
/// </summary>
// Name: PostCarganovimResponseWrapper
public partial struct ST_6636acdf9f49922edfd43b4865475460Structure : ITypedRecord<ST_6636acdf9f49922edfd43b4865475460Structure> {
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*9ahzRwD1JUiD13WAhOkI9A");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*dLmYzcrIHEu+wYscX_xJ4A");
internal static readonly GlobalObjectKey IdCargaCFDResult = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*oo1egkq0kU6RG4N2+ifm_w");
internal static readonly GlobalObjectKey IdCfdFile = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*YC+WGzUXl02KTAr7kjiMlQ");

public long ssCode;

public string ssMessage;

public ST_3feabb059aa2546826b3076d3b237751Structure ssCargaCFDResult;

public ST_1e51b813a2c6a26cea1c6c8c17329da8Structure ssCfdFile;


public BitArray OptimizedAttributes;

public ST_6636acdf9f49922edfd43b4865475460Structure() {
OptimizedAttributes = null;
ssCode = 0L;
ssMessage = "";
ssCargaCFDResult = new ST_3feabb059aa2546826b3076d3b237751Structure();
ssCfdFile = new ST_1e51b813a2c6a26cea1c6c8c17329da8Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssCargaCFDResult.OptimizedAttributes = value[0];
    ssCfdFile.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssCode = r.ReadLongInteger(index++, "PostCarganovimResponseWrapper.Code", 0L);
ssMessage = r.ReadText(index++, "PostCarganovimResponseWrapper.Message", "");
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
public void ReadIM(ST_6636acdf9f49922edfd43b4865475460Structure r) {
this = r;
}


public static bool operator == (ST_6636acdf9f49922edfd43b4865475460Structure a, ST_6636acdf9f49922edfd43b4865475460Structure b) {
if (a.ssCode != b.ssCode) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssCargaCFDResult != b.ssCargaCFDResult) return false;
if (a.ssCfdFile != b.ssCfdFile) return false;
return true;
}

public static bool operator != (ST_6636acdf9f49922edfd43b4865475460Structure a, ST_6636acdf9f49922edfd43b4865475460Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6636acdf9f49922edfd43b4865475460Structure)) return false;
return (this == (ST_6636acdf9f49922edfd43b4865475460Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssCargaCFDResult.GetHashCode()
 ^ ssCfdFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssCargaCFDResult.RecursiveReset();
ssCfdFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssCargaCFDResult.InternalRecursiveSave();
ssCfdFile.InternalRecursiveSave();
}


public ST_6636acdf9f49922edfd43b4865475460Structure Duplicate() {
ST_6636acdf9f49922edfd43b4865475460Structure t;
t.ssCode = this.ssCode;
t.ssMessage = this.ssMessage;
t.ssCargaCFDResult = (ST_3feabb059aa2546826b3076d3b237751Structure)this.ssCargaCFDResult.Duplicate();
t.ssCfdFile = (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure)this.ssCfdFile.Duplicate();
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
if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "cargacfdresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CargaCFDResult")) variable.Value = ssCargaCFDResult; else variable.Optimized = true;
variable.SetFieldName("cargacfdresult");
} else if (head == "cfdfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CfdFile")) variable.Value = ssCfdFile; else variable.Optimized = true;
variable.SetFieldName("cfdfile");
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
if (key == IdCode) {
return ssCode;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdCargaCFDResult) {
return ssCargaCFDResult;
}
if (key == IdCfdFile) {
return ssCfdFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdCargaCFDResult.Key.AsGuid) {
return ssCargaCFDResult;
}
if (attributeKey == IdCfdFile.Key.AsGuid) {
return ssCfdFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCode = (long) other.AttributeGet(IdCode);
ssMessage = (string) other.AttributeGet(IdMessage);
ssCargaCFDResult.FillFromOther((IRecord) other.AttributeGet(IdCargaCFDResult));
ssCfdFile.FillFromOther((IRecord) other.AttributeGet(IdCfdFile));
}
} // ST_6636acdf9f49922edfd43b4865475460Structure
/// <summary>
/// RecordList type <code>PostCarganovimResponseWrapperList</code> that represents a record list of
///  <code>PostCarganovimResponseWrapper</code>
/// </summary>
public partial class RL_1e8f8fabc78a1d17f7b0c1af9f47039c : GenericRecordList<ST_6636acdf9f49922edfd43b4865475460Structure>, IEnumerable, IEnumerator {

protected override ST_6636acdf9f49922edfd43b4865475460Structure GetElementDefaultValue() {
return new ST_6636acdf9f49922edfd43b4865475460Structure();
}

public T[] ToArray<T>(Func<ST_6636acdf9f49922edfd43b4865475460Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1e8f8fabc78a1d17f7b0c1af9f47039c recordList, Func<ST_6636acdf9f49922edfd43b4865475460Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1e8f8fabc78a1d17f7b0c1af9f47039c(ST_6636acdf9f49922edfd43b4865475460Structure[] array) {
  RL_1e8f8fabc78a1d17f7b0c1af9f47039c result = new RL_1e8f8fabc78a1d17f7b0c1af9f47039c();
result.InnerFromArray(array);
    return result;
}

public static RL_1e8f8fabc78a1d17f7b0c1af9f47039c ToList<T>(T[] array, Func <T, ST_6636acdf9f49922edfd43b4865475460Structure> converter) {
  RL_1e8f8fabc78a1d17f7b0c1af9f47039c result = new RL_1e8f8fabc78a1d17f7b0c1af9f47039c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1e8f8fabc78a1d17f7b0c1af9f47039c FromRestList<T>(RestList<T> restList, Func <T, ST_6636acdf9f49922edfd43b4865475460Structure> converter) {
  RL_1e8f8fabc78a1d17f7b0c1af9f47039c result = new RL_1e8f8fabc78a1d17f7b0c1af9f47039c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1e8f8fabc78a1d17f7b0c1af9f47039c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = null;
def[1] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6636acdf9f49922edfd43b4865475460Structure> NewList() {
return new RL_1e8f8fabc78a1d17f7b0c1af9f47039c();
}


} // RL_1e8f8fabc78a1d17f7b0c1af9f47039c
}

